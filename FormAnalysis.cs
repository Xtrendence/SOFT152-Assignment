using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT152Assignment
{
	public partial class FormAnalysis : Form
	{
		public bool drawingEnabled;
		public int districtStart;
		public int neighborhoodStart;
		public int districtEnd;
		public int neighborhoodEnd;
		public int neighborhoodTotal;
		public FormAnalysis()
		{
			InitializeComponent();
			this.districtStart = 0;
			this.neighborhoodStart = 0;
			this.districtEnd = 6;
			this.neighborhoodEnd = 6;
			this.neighborhoodTotal = 0;
			this.drawingEnabled = true;
			panelNeighborhood.Invalidate();
			panelProperty.Invalidate();
		}
  
		private void DrawBars(int start, int end, string category)
		{
			int nameAdjustment = 10;
			int barWidth = 60;
			int totalWidth = 120 + barWidth + 22;
			
			Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);

			if(category == "neighborhood")
			{
				int panelNeighborhoodHeight = panelNeighborhood.Height;
				int neighborhoodBarHeightAdjustment = 5;
				int marginNeighborhood = 58;
				int marginDistrictName = 0;

				panelDistrictNames.Controls.Clear();

				SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0, 125, 255));
				for(int i = start; i < end; i++)
				{
					try
					{
						District district = Data.districts[i];
						int neighborhoodCount = district.NeighborhoodCount;

						Graphics neighborhoodBar = panelNeighborhood.CreateGraphics();

						int neighborhoodBarHeight = neighborhoodCount * neighborhoodBarHeightAdjustment;
						int neighborhoodBarTop = panelNeighborhoodHeight - neighborhoodBarHeight;

						neighborhoodBar.FillRectangle(blueBrush, new Rectangle(marginNeighborhood, neighborhoodBarTop, barWidth, neighborhoodBarHeight));
						neighborhoodBar.Dispose();
						marginNeighborhood += totalWidth;

						Label labelDistrictName = new Label();
						labelDistrictName.Text = district.Name + " (" + neighborhoodCount + ")";
						labelDistrictName.AutoSize = false;
						labelDistrictName.ForeColor = Color.FromArgb(245, 245, 245);
						labelDistrictName.Font = font;
						labelDistrictName.Width = totalWidth - nameAdjustment;
						labelDistrictName.TextAlign = ContentAlignment.MiddleCenter;
						labelDistrictName.Top = 0;
						labelDistrictName.Left = marginDistrictName;
						panelDistrictNames.Controls.Add(labelDistrictName);
						marginDistrictName += totalWidth;
					}
					catch(IndexOutOfRangeException e)
					{
						Debug.WriteLine(e.Message);
					}
				}
				blueBrush.Dispose();
			}
			else if(category == "property")
			{
				int panelPropertyHeight = panelProperty.Height;
				double propertyBarHeightAdjustment = 1.5;
				int marginProperty = 58;
				int marginNeighborhoodName = 0;

				panelNeighborhoodNames.Controls.Clear();

				SolidBrush orangeBrush = new SolidBrush(Color.FromArgb(230, 150, 0));
				foreach(District district in Data.districts)
				{
					for(int i = start; i < end; i++)
					{
						try
						{
							Neighborhood neighborhood = district.Neighborhoods[i];
							int propertyCount = neighborhood.PropertyCount;

							Graphics propertyBar = panelProperty.CreateGraphics();

							int propertyBarHeight = Convert.ToInt32(Math.Round(propertyCount * propertyBarHeightAdjustment));
							int propertyBarTop = panelPropertyHeight - propertyBarHeight;

							Rectangle rectangle = new Rectangle(marginProperty, propertyBarTop, barWidth, propertyBarHeight);
							propertyBar.FillRectangle(orangeBrush, rectangle);
							propertyBar.Dispose();
							marginProperty += totalWidth;

							Label labelNeighborhoodName = new Label();
							labelNeighborhoodName.Text = neighborhood.Name + " (" + propertyCount + ")";
							labelNeighborhoodName.AutoSize = false;
							labelNeighborhoodName.ForeColor = Color.FromArgb(245, 245, 245);
							labelNeighborhoodName.Font = font;
							labelNeighborhoodName.Width = totalWidth - nameAdjustment;
							labelNeighborhoodName.TextAlign = ContentAlignment.MiddleCenter;
							labelNeighborhoodName.Top = 0;
							labelNeighborhoodName.Left = marginNeighborhoodName;
							panelNeighborhoodNames.Controls.Add(labelNeighborhoodName);
							marginNeighborhoodName += totalWidth;
						}
						catch(IndexOutOfRangeException e)
						{
							Debug.WriteLine(e.Message);
						}
					}
				}
				orangeBrush.Dispose();
			}
		}

		private void ButtonPreviousDistrict_Click(object sender, EventArgs e)
		{
			if(this.districtStart - 6 > Data.districts.Length)
			{
				this.districtStart -= 6;
			}
			if(this.districtEnd - 6 > Data.districts.Length)
			{
				this.districtEnd -= 6;
			}
			panelNeighborhood.Invalidate();
		}

		private void ButtonNextDistrict_Click(object sender, EventArgs e)
		{
			if(this.districtStart + 6 < Data.districts.Length)
			{
				this.districtStart += 6;
			}
			if(this.districtEnd + 6 < Data.districts.Length)
			{
				this.districtEnd += 6;
			}
			panelNeighborhood.Invalidate();
		}

		private void ButtonPreviousNeighborhood_Click(object sender, EventArgs e)
		{
			if(this.neighborhoodStart - 6 < this.neighborhoodTotal)
			{
				this.neighborhoodStart -= 6;
			}
			if(this.neighborhoodEnd - 6 < this.neighborhoodTotal)
			{
				this.neighborhoodEnd -= 6;
			}
			panelProperty.Invalidate();
		}

		private void ButtonNextNeighborhood_Click(object sender, EventArgs e)
		{
			if(this.neighborhoodStart + 6 < this.neighborhoodTotal)
			{
				this.neighborhoodStart += 6;
			}
			if(this.neighborhoodEnd + 6 < this.neighborhoodTotal)
			{
				this.neighborhoodEnd += 6;
			}
			panelProperty.Invalidate();
		}
  
		private void PanelNeighborhood_Paint(object sender, PaintEventArgs e)
		{
			if(this.drawingEnabled)
			{
				if(this.districtStart < 0)
				{
					this.districtStart = 0;
				}
				if(this.districtEnd > Data.districts.Length)
				{
					this.districtEnd = Data.districts.Length;
				}
				DrawBars(this.districtStart, this.districtEnd, "neighborhood");
			}
		}

		private void PanelProperty_Paint(object sender, PaintEventArgs e)
		{
			if(this.drawingEnabled)
			{
				foreach(District district in Data.districts)
				{
					this.neighborhoodTotal += district.NeighborhoodCount;
				}
				if(this.neighborhoodStart < 0)
				{
					this.neighborhoodStart = 0;
				}
				if(this.neighborhoodEnd > this.neighborhoodTotal - 1)
				{
					this.neighborhoodEnd = this.neighborhoodTotal - 1;
				}
				DrawBars(this.neighborhoodStart, this.neighborhoodEnd, "property");
			}
		}
	}
}
