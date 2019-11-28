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
		// Used to prevent an infinite loop where the bars are redrawn until the app crashes.
		public bool drawingEnabled;
		// Used to determine how many bars should be visible at any given moment per panel.
		public int barsVisible;
		// Used to track how many bars are visible in calculations to determine whether or not the "Previous" and "Next" buttons should be visible.
		public int barsTrack;

		// Determines the start point of the for loop that is responsible for displaying the districts.
		public int districtStart;
		// Determines the start point of the for loop that is responsible for displaying the neighborhoods.
		public int neighborhoodStart;

		// Determines the end point of the for loop that is responsible for displaying the districts.
		public int districtEnd;
		// Determines the end point of the for loop that is responsible for displaying the neighborhoods.
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

			// Triggers the "Paint" event listener.
			panelNeighborhood.Invalidate();
			panelProperty.Invalidate();
		}
  
		private void DrawBars(int start, int end, string category)
		{
			// Margin for the district and neighborhood name labels.
			int nameAdjustment = 10;
			// The width of the rectangles or bars.
			int barWidth = 60;
			// The total width each bar takes up, which is determined by padding + the width of each bar + more padding.
			int totalWidth = 120 + barWidth + 22;
			
			Font font = new Font("Arial", 11, FontStyle.Bold, GraphicsUnit.Point);

			if(category == "neighborhood")
			{
				int panelNeighborhoodHeight = panelNeighborhood.Height;

				// Since the height of each bar is the same number of pixels as how children the parent has, an adjustment is made so if a district has 1 neighborhood, it doesn't end up as 1px in terms of height.
				int neighborhoodBarHeightAdjustment = 5;

				// Spacing.
				int marginNeighborhood = 58;
				int marginDistrictName = 0;

				// Removes the district name labels.
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

						// If the bar is taller than the actual panel, then it's adjusted to be shorter.
						if(neighborhoodBarHeight >= panelNeighborhoodHeight)
						{
							neighborhoodBarHeight = panelNeighborhoodHeight - 20;
						}

						// Used to determine the Y position of the bar.
						int neighborhoodBarTop = panelNeighborhoodHeight - neighborhoodBarHeight;

						neighborhoodBar.FillRectangle(blueBrush, new Rectangle(marginNeighborhood, neighborhoodBarTop, barWidth, neighborhoodBarHeight));
						neighborhoodBar.Dispose();

						// Each time a bar is added, the margin is incremented by the total width of that bar and its name label. This is what keeps the bars and names spaced out.
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
				// Since there are a lot of properties, the height adjustment here is much lower than it is for districts.
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
			// If the start position - the number of bars is less than zero, then that means there are no more items before the current ones on display.
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
			// If the start position + the number of bars is less than the number of items, then there are still items left to show.
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
