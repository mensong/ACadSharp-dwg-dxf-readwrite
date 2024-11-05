using ACadSharp.Attributes;
using CSMath;
using System.Collections.Generic;

namespace ACadSharp.Entities
{
	public partial class Hatch
	{
		public partial class BoundaryPath
		{
			public class Line : Edge
			{
				public override EdgeType Type => EdgeType.Line;

				/// <summary>
				/// Start point (in OCS)
				/// </summary>
				[DxfCodeValue(10, 20)]
				public XY Start { get; set; }

				/// <summary>
				/// Endpoint (in OCS)
				/// </summary>
				[DxfCodeValue(11, 21)]
				public XY End { get; set; }


				/// <inheritdoc/>
				public override BoundingBox GetBoundingBox()
				{
					List<XYZ> arrPts = new List<XYZ>();
					arrPts.Add(new XYZ(this.Start.X, this.Start.Y, 0));
					arrPts.Add(new XYZ(this.End.X, this.End.Y, 0));
					return BoundingBox.FromPoints(arrPts);
				}
			}
		}
	}
}
