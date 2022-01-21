﻿using Flagrum.Core.Gfxbin.Gmdl;
using Flagrum.Core.Gfxbin.Gmdl.Constructs;
using Flagrum.Core.Gfxbin.Gmtl;
using Newtonsoft.Json;

namespace Flagrum.Blender;

public static class Program
{
    public static void Main(string[] args)
    {
        var command = args[0];
        var parameterInput = args[1];
        var inputPath = args[2];
        var parameterOutput = args[3];
        var outputPath = args[4];

        switch (command)
        {
            case "import":
                Import(inputPath, outputPath);
                break;
            case "material":
                Material(inputPath, outputPath);
                break;
        }
    }

    private static void Material(string inputPath, string outputPath)
    {
        var reader = new MaterialReader(inputPath);
        var material = reader.Read();

        var result = material.InterfaceInputs
            .Where(i => i.InterfaceIndex == 0)
            .ToDictionary(i => i.ShaderGenName, i => i.Values);

        var json = JsonConvert.SerializeObject(result);
        File.WriteAllText(outputPath, json);
    }

    private static void Import(string inputPath, string outputPath)
    {
        var gfxbin = File.ReadAllBytes(inputPath);
        var gpubin = File.ReadAllBytes(inputPath.Replace(".gmdl.gfxbin", ".gpubin"));
        var reader = new ModelReader(gfxbin, gpubin);
        var model = reader.Read();

        Dictionary<int, string> boneTable;
        if (model.BoneHeaders.Count(b => b.UniqueIndex == ushort.MaxValue) > 1)
        {
            // Probably a broken MO gfxbin with all IDs set to this value
            var arbitraryIndex = 0;
            boneTable = model.BoneHeaders.ToDictionary(b => arbitraryIndex++, b => b.Name);
        }
        else
        {
            boneTable = model.BoneHeaders.ToDictionary(b => (int)(b.UniqueIndex == 65535 ? 0 : b.UniqueIndex),
                b => b.Name);
        }

        var meshData = new Gpubin
        {
            BoneTable = boneTable,
            Meshes = model.MeshObjects.SelectMany(o => o.Meshes
                .Where(m => m.LodNear == 0)
                .Select(m => new GpubinMesh
                {
                    Name = m.Name,
                    FaceIndices = m.FaceIndices,
                    VertexPositions = m.VertexPositions,
                    ColorMaps = m.ColorMaps,
                    Normals = m.Normals,
                    UVMaps = m.UVMaps.Select(m => new UVMap32
                    {
                        UVs = m.UVs.Select(uv => new UV32
                        {
                            U = (float)uv.U,
                            V = (float)uv.V
                        }).ToList()
                    }).ToList(),
                    WeightIndices = m.WeightIndices,
                    WeightValues = m.WeightValues
                        .Select(n => n.Select(o => o.Select(p => (int)p).ToArray()).ToList())
                        .ToList()
                }))
        };

        var json = JsonConvert.SerializeObject(meshData);
        File.WriteAllText(outputPath, json);
    }
}