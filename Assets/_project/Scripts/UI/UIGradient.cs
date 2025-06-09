using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Graphic))]
public class UIGradient : BaseMeshEffect
{
    public Color topColor = Color.white;
    public Color bottomColor = Color.black;

    public override void ModifyMesh(VertexHelper vh)
    {
        if (!IsActive()) return;

        UIVertex vertex = new UIVertex();
        float bottomY = float.MaxValue;
        float topY = float.MinValue;

        for (int i = 0; i < vh.currentVertCount; i++)
        {
            vh.PopulateUIVertex(ref vertex, i);
            float y = vertex.position.y;
            if (y > topY) topY = y;
            if (y < bottomY) bottomY = y;
        }

        float height = topY - bottomY;

        for (int i = 0; i < vh.currentVertCount; i++)
        {
            vh.PopulateUIVertex(ref vertex, i);
            float ratio = (vertex.position.y - bottomY) / height;
            vertex.color = Color.Lerp(bottomColor, topColor, ratio);
            vh.SetUIVertex(vertex, i);
        }
    }
}

