using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnyCAD.Platform;

namespace AnyCAD.Basic
{
    public class LoadDxfContext : AnyCAD.Platform.TopoShapeReaderContext
    {
        public TopoShapeGroup ShapeGroup = new TopoShapeGroup();

        public LoadDxfContext()
        {
        }

        public override void OnBeginGroup(String name)
        {
        }

        public override void OnEndGroup()
        {

        }

        public override bool OnBeiginComplexShape(TopoShape shape)
        {
            return true;
        }

        public override void OnEndComplexShape()
        {
      
        }

        public override void OnFace(TopoShape shape)
        {
 
        }

        public override void OnWire(TopoShape shape)
        {
            ShapeGroup.Add(shape);
        }

        public override void OnEdge(TopoShape shape)
        {
            ShapeGroup.Add(shape);
        }

        public override void OnPoint(TopoShape shape)
        {

        }

      
    }
}
