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
		public bool resizeNeighborhood = true;
		public bool resizeProperty = true;
		public FormAnalysis()
		{
			InitializeComponent();
		}

		private void PanelNeighborhood_Paint(object sender, PaintEventArgs e)
		{
			Analyze();
		}

		private void PanelProperty_Paint(object sender, PaintEventArgs e)
		{
			Analyze();
		}
  
		private void Analyze()
		{
			int panelNeighborhoodHeight = panelNeighborhood.Height;
			int panelPropertyHeight = panelProperty.Height;

			int neighborhoodBarHeightAdjustment = 10;
			int propertyBarHeightAdjustment = 10;
			int barWidth = 60;
			int totalWidth = 160 + barWidth;
			int marginNeighborhood = 58;
			int marginProperty = 58;
			int marginDistrictName = 48;
			int marginNeighborhoodName = 48;

			SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0, 125, 255));
			SolidBrush orangeBrush = new SolidBrush(Color.FromArgb(230, 150, 0));
			Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);

			foreach(District district in Data.districts)
			{
				int neighborhoodCount = district.NeighborhoodCount;
				
				if(this.resizeNeighborhood)
				{
					labelNeighborhood.Width += totalWidth;
				}

				Graphics neighborhoodBar = panelNeighborhood.CreateGraphics();

				int neighborhoodBarHeight = neighborhoodCount * neighborhoodBarHeightAdjustment;
				while(neighborhoodBarHeight > panelNeighborhoodHeight)
				{
					neighborhoodBarHeightAdjustment--;
					neighborhoodBarHeight = neighborhoodBarHeight * neighborhoodBarHeightAdjustment;
				}

				neighborhoodBar.FillRectangle(blueBrush, new Rectangle(marginNeighborhood, 20, barWidth, neighborhoodBarHeight));
				neighborhoodBar.Dispose();
				marginNeighborhood += totalWidth;

				Label labelDistrictName = new Label();
				labelDistrictName.Text = district.Name;
				labelDistrictName.AutoSize = false;
				labelDistrictName.ForeColor = Color.FromArgb(245, 245, 245);
				labelDistrictName.Font = font;
				labelDistrictName.Width = totalWidth;
				labelDistrictName.Top = 0;
				labelDistrictName.Left = marginDistrictName;
				panelDistrictNames.Controls.Add(labelDistrictName);
				marginDistrictName += totalWidth;

				foreach(Neighborhood neighborhood in district.Neighborhoods)
				{
					int propertyCount = neighborhood.PropertyCount;

					if(this.resizeProperty)
					{
						labelProperty.Width += totalWidth;
					}

					Graphics propertyBar = panelProperty.CreateGraphics();

					int propertyBarHeight = propertyCount * propertyBarHeightAdjustment;
					while(propertyBarHeight > panelPropertyHeight)
					{
						propertyBarHeightAdjustment--;
						propertyBarHeight = propertyCount * propertyBarHeightAdjustment;
					}

					Rectangle rectangle = new Rectangle(marginProperty, 20, barWidth, propertyBarHeight);
					propertyBar.FillRectangle(orangeBrush, rectangle);
					propertyBar.Dispose();
					marginProperty += totalWidth;

					Label labelNeighborhoodName = new Label();
					labelNeighborhoodName.Text = neighborhood.Name;
					labelNeighborhoodName.AutoSize = false;
					labelNeighborhoodName.ForeColor = Color.FromArgb(245, 245, 245);
					labelNeighborhoodName.Font = font;
					labelNeighborhoodName.Width = totalWidth;
					labelNeighborhoodName.Top = 0;
					labelNeighborhoodName.Left = marginNeighborhoodName;
					panelNeighborhoodNames.Controls.Add(labelNeighborhoodName);
					marginNeighborhoodName += totalWidth;
				}
			}
			this.resizeNeighborhood = false;
			this.resizeProperty = false;
			blueBrush.Dispose();
		}
	}
}
