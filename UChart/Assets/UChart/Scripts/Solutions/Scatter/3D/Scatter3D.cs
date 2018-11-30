﻿
using UnityEngine;

namespace UChart.Scatter
{
    public class Scatter3D : Scatter
    {
        private Material m_material;

        public Material material
        {
            get { return m_material; }
            set { m_material = value; }
        }

        public override void Generate(Vector3 size)
        {
            myGameobject.AddComponent<Anim4Point2D_01>();
        }

        #region properties && events

        protected override void SetColor(Color color)
        {
            //m_meshRenderer.material.SetColor("_Color",color);
        }

        protected override void SetAlpha(float alpha)
        {
            //m_meshRenderer.material.SetFloat("_Alpha",alpha);
        }

        protected override void SetSize(float size)
        {
            if (null == this.scatterGraph)
                return;

            this.scatterGraph.RefreshScatter();
        }

        protected override void OnMouseEnter()
        {
            //base.OnMouseEnter();
            color = new Color(color.r,color.g,color.b,size * 1.5f);
            ((ScatterGraph3D)this.scatterGraph).RefreshMeshData(this.index,color);
            this.scatterGraph.RefreshScatter();
        }

        protected override void OnMouseExit()
        {
            //base.OnMouseExit();
            color = new Color(color.r,color.g,color.b,size);
            ((ScatterGraph3D)this.scatterGraph).RefreshMeshData(this.index,color);
            this.scatterGraph.RefreshScatter();
        }

        protected override void OnMouseUpAsButton()
        {
            base.OnMouseUpAsButton();
        }

        #endregion
    }
}