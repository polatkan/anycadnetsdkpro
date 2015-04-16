using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnyCAD.Platform;

namespace AnyCAD.Basic
{
    class MeasureDistanceEditor : AnyCAD.Platform.CustomEditor
    {
        private int m_Step = 0;
        TopoShape m_Shape1 = null;

        enum EditStep
        {
            ES_Init,
            ES_Drawing,
            ES_Finish,
        };

        TopoShape GetSelectedShape(int cx, int cy)
        {
            Renderer rv = GetRenderer();
            rv.ClearHighlight();
            if (rv.Highlight(cx, cy) > 0)
            {
                Platform.QuerySelectedElementContext context = new Platform.QuerySelectedElementContext();
                rv.QueryHighlight(context);

                return context.GetGeometry();
            }

            return null;
        }

        public override void OnStartEvent()
        {
        }

        public override void OnExitEvent()
        {
  
        }

        public override void OnButtonDownEvent(InputEvent evt)
        {
            TopoShape shape = GetSelectedShape((int)evt.GetMousePosition().X, (int)evt.GetMousePosition().Y);
            if(shape == null)
                return;

            Renderer renderer = GetRenderer();
            m_Step += 1;
            if (m_Step == (int)EditStep.ES_Finish)
            {
                m_Step = (int)EditStep.ES_Init;

                MeasureTools mt = new MeasureTools();
                MeasureResult rt = mt.ComputeMinDistance(m_Shape1, shape);

                LineNode lineNode = new LineNode();
                lineNode.SetShowText(true);
                lineNode.Set(rt.GetPointOnShape1(), rt.GetPointOnShape2());

                renderer.GetSceneManager().AddNode(lineNode);
                renderer.RequestDraw(1);
                return;
            }

            if (evt.IsLButtonDown())
            {
                
                m_Shape1 = shape;
            }
        }

        public override void OnButtonUpEvent(InputEvent evt)
        {
        }

        public override void OnMouseMoveEvent(InputEvent evt)
        {
        }
    }
}
