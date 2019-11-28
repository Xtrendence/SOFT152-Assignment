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
		public int barsVisible;
		public int barsTrack;

		public int districtStart;
		public int neighborhoodStart;

		public int districtEnd;
		public int neighborhoodEnd;

		public Neighborhood[] neighborhoods = new Neighborhood[0];

		public FormAnalysis()
		{
			InitializeComponent();
			this.districtStart = 0;
			this.neighborhoodStart = 0;
			this.barsVisible = 7;
			this.barsTrack = 7;
			this.districtEnd = barsVisible;
			this.neighborhoodEnd = barsVisible;
			this.drawingEnabled = true;

			if(this.neighborhoods.Length == 0)
			{
				foreach(District district in Data.districts)
				{
					foreach(Neighborhood neighborhood in district.Neighborhoods)
					{
						int length = this.neighborhoods.Length;
						Array.Resize(ref this.neighborhoods, length + 1);
						this.neighborhoods[length] = neighborhood;
					}
				}
			}

			panelNeighborhood.Invalidate();
			panelProperty.Invalidate();
		}
  
		private void DrawBars(int start, int end, string category)
		{
			int nameAdjustment = 10;
			int barWidth = 60;
			int totalWidth = 120 + barWidth + 22;
			
			Font font = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point);

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
						if(neighborhoodBarHeight >= panelNeighborhoodHeight)
						{
							neighborhoodBarHeight = panelNeighborhoodHeight - 20;
						}
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
				for(int i = start; i < end; i++)
				{
					try
					{
						Neighborhood neighborhood = neighborhoods[i];
						int propertyCount = neighborhood.PropertyCount;

						Graphics propertyBar = panelProperty.CreateGraphics();

						int propertyBarHeight = Convert.ToInt32(Math.Round(propertyCount * propertyBarHeightAdjustment));
						if(propertyBarHeight >= panelPropertyHeight)
						{
							propertyBarHeight = panelPropertyHeight - 20;
						}
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
				orangeBrush.Dispose();
			}
		}

		private void ButtonPreviousDistrict_Click(object sender, EventArgs e)
		{
			if(this.districtStart - barsTrack < 0)
			{
				buttonPreviousDistrict.Visible = false;
				this.districtStart = 0;
				this.districtEnd = barsTrack;
			}
			else
			{
				buttonPreviousDistrict.Visible = true;
				this.districtStart -= barsTrack;
				this.districtEnd -= barsTrack;
			}
			if(this.districtStart + barsTrack < Data.districts.Length)
			{
				buttonNextDistrict.Visible = true;
			}
			else
			{
				buttonNextDistrict.Visible = false;
			}
			if(this.districtEnd - barsTrack <= 0)
			{
				buttonPreviousDistrict.Visible = false;
			}
			panelNeighborhood.Invalidate();
		}

		private void ButtonNextDistrict_Click(object sender, EventArgs e)
		{
			buttonPreviousDistrict.Visible = true;
			if(this.districtStart + barsTrack >= Data.districts.Length)
			{
				buttonNextDistrict.Visible = false;
				this.districtStart = Data.districts.Length;
				this.districtEnd = Data.districts.Length;
			}
			else
			{
				buttonNextDistrict.Visible = true;
				this.districtStart += barsTrack;
				this.districtEnd += barsTrack;
			}
			panelNeighborhood.Invalidate();
		}

		private void ButtonPreviousNeighborhood_Click(object sender, EventArgs e)
		{
			if(this.neighborhoodStart - barsTrack < 0)
			{
				buttonPreviousNeighborhood.Visible = false;
				this.neighborhoodStart = 0;
				this.neighborhoodEnd = barsTrack;
			}
			else
			{
				buttonPreviousNeighborhood.Visible = true;
				this.neighborhoodStart -= barsTrack;
				this.neighborhoodEnd -= barsTrack;
			}
			if(this.neighborhoodStart + barsTrack < neighborhoods.Length)
			{
				buttonNextNeighborhood.Visible = true;
			}
			else
			{
				buttonNextNeighborhood.Visible = false;
			}
			if(this.neighborhoodEnd - barsTrack <= 0)
			{
				buttonPreviousNeighborhood.Visible = false;
			}
			panelProperty.Invalidate();
		}

		private void ButtonNextNeighborhood_Click(object sender, EventArgs e)
		{
			buttonPreviousNeighborhood.Visible = true;
			Debug.WriteLine(neighborhoodStart);
			Debug.WriteLine(neighborhoods.Length);
			if(this.neighborhoodStart + barsTrack >= neighborhoods.Length)
			{
				buttonNextNeighborhood.Visible = false;
				this.neighborhoodStart = neighborhoods.Length;
				this.neighborhoodEnd = neighborhoods.Length;
			}
			else
			{
				buttonNextNeighborhood.Visible = true;
				this.neighborhoodStart += barsTrack;
				this.neighborhoodEnd += barsTrack;
			}
			panelProperty.Invalidate();
		}
  
		private void PanelNeighborhood_Paint(object sender, PaintEventArgs e)
		{
			if(this.drawingEnabled)
			{
				if(this.districtStart + barsTrack >= Data.districts.Length)
				{
					buttonNextDistrict.Visible = false;
				}
				DrawBars(this.districtStart, this.districtEnd, "neighborhood");
			}
		}

		private void PanelProperty_Paint(object sender, PaintEventArgs e)
		{
			if(this.drawingEnabled)
			{
				if(this.neighborhoodStart + barsTrack >= neighborhoods.Length)
				{
					buttonNextNeighborhood.Visible = false;
				}
				DrawBars(this.neighborhoodStart, this.neighborhoodEnd, "property");
			}
		}
	}
}
