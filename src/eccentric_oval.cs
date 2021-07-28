using System;
using System.Linq;
using System.Collections.Generic;

namespace EccentricOval
{
	class EccentricOval
	{
		public double diameter;
		public double displacement;
		public double angle;

		public double ratio;
		public double oval_ang;

		public EccentricOval (double diam, double dist, double ang, double rat, double oang)
		{
			this.diameter = diam;
			this.displacement = dist;
			this.angle = ang;

			this.ratio = rat;
			this.oval_ang = oang;
		}

		public EccentricOval (double diam, double dist, double ang)
			: this(diam, dist, ang, 1.0, 0.0)
		{
		}

		public EccentricOval (double diam)
			: this(diam, 0.0, 0.0, 1.0, 0.0)
		{
		}
		
		public List<Tuple<double, double>> Sampling (double stepang)
		{
			double minor_diam = this.diameter * this.ratio;

			var samples = new List<Tuple<double, double>>();
			for (double ang = -this.angle
					; ang < 2.0 * Math.PI - this.angle; ang += stepang)
			{
				samples.Add(new Tuple<double, double>(this.diameter / 2.0 * Math.Cos(ang)
							+ this.displacement / 2.0 * Math.Cos(this.angle)
							, minor_diam / 2.0 * Math.Sin(ang)
							+ this.displacement / 2.0 * Math.Sin(this.angle)));
			}
			return samples;
		}
	}
}
