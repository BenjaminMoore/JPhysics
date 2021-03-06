﻿namespace JPhysics.Unity
{
    using Collision.Shapes;
    using UnityEngine;

    [AddComponentMenu("JPhysics/Colliders/JTerrain"), RequireComponent(typeof(TerrainCollider))]
    public class JTerrain : JCollider
    {
        protected override Shape MakeShape()
        {
            var data = GetComponent<TerrainCollider>().terrainData;
            var hs = data.GetHeights(0, 0, data.heightmapWidth, data.heightmapHeight);
            var temp = new float[hs.GetLength(0), hs.GetLength(1)];
            for (var i0 = 0; i0 < hs.GetLength(0); i0++)
                for (var i1 = 0; i1 < hs.GetLength(1); i1++)
                {
                    hs[i0, i1] *= (data.heightmapHeight / data.heightmapResolution) * data.heightmapScale.y;
                    temp[i1, i0] = hs[i0, i1];
                }
            return new TerrainShape(temp, data.heightmapScale.x, data.heightmapScale.z);
        }
    }
}
