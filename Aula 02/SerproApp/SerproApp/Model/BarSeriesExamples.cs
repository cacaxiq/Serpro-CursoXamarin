using System;
using System.Linq;
using System.Collections.Generic;

namespace SerproApp.Model
{
    using OxyPlot;
    using OxyPlot.Axes;
    using OxyPlot.Series;

    public static class BarSeriesExamples
    {
        public static PlotModel BarSeries()
        {

            var model = new PlotModel { Title = "Cake Type Popularity" };

            //generate a random percentage distribution between the 5
            //cake-types (see axis below)
            var rand = new Random();
            double[] cakePopularity = new double[5];
            for (int i = 0; i < 5; ++i)
            {
                cakePopularity[i] = rand.NextDouble();
            }
            var sum = cakePopularity.Sum();

            var barSeries = new BarSeries
            {
                ItemsSource = new List<BarItem>(new[]
                    {
                        new BarItem{ Value = (cakePopularity[0] / sum * 100) },
                        new BarItem{ Value = (cakePopularity[1] / sum * 100) },
                        new BarItem{ Value = (cakePopularity[2] / sum * 100) },
                        new BarItem{ Value = (cakePopularity[3] / sum * 100) },
                        new BarItem{ Value = (cakePopularity[4] / sum * 100) }
                    }),
                FillColor = OxyColor.Parse("#3cbe9a"),
                StrokeColor = OxyColor.Parse("#000000"),

            };
            model.Series.Add(barSeries);

            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "CakeAxis",
                ItemsSource = new[]
                    {
                        "Apple cake",
                        "Baumkuchen",
                        "Bundt Cake",
                        "Chocolate cake",
                        "Carrot cake"
                    }
            });

            return model;
        }

        public static PlotModel SerproSeries(string titulo)
        {

            var model = new PlotModel();

            model.PlotAreaBackground = OxyPlot.OxyColor.Parse("#F5F9E7");
            model.SelectionColor = OxyColors.Red;
            model.PlotAreaBorderColor = OxyColor.Parse("#646471");
            model.Title = titulo;
            model.TitleColor = OxyColor.Parse("#646471");
            model.LegendPosition = LegendPosition.RightMiddle;
            model.LegendPlacement = LegendPlacement.Inside;
            model.LegendTextColor = OxyColors.White;
            model.IsLegendVisible = true;

            //generate a random percentage distribution between the 5
            //cake-types (see axis below)
            var rand = new Random();
            double[] cakePopularity = new double[12];

			for (int i = 0; i < 12; ++i)
			{
				cakePopularity[i] = rand.Next(1000000, 1800000);
			}

			List<BarItem> lista = new List<BarItem>(new[]
                    {
                        new BarItem{ Value = (cakePopularity[0]), },
                        new BarItem{ Value = (cakePopularity[1] ) },
                        new BarItem{ Value = (cakePopularity[2] ) },
                        new BarItem{ Value = (cakePopularity[3] ) },
                        new BarItem{ Value = (cakePopularity[4] ) },
                        new BarItem{ Value = (cakePopularity[5] ) },
                        new BarItem{ Value = (cakePopularity[6] ) },
                        new BarItem{ Value = (cakePopularity[7] ) },
                        new BarItem{ Value = (cakePopularity[8] ) },
                        new BarItem{ Value = (cakePopularity[9] ) },
                        new BarItem{ Value = (cakePopularity[10] ) },
                        new BarItem{ Value = (cakePopularity[11] ) }
            });

          

            var barSeries = new BarSeries
            {
                ItemsSource = lista,
                FillColor = OxyColor.Parse("#646471"),
                SelectionMode = SelectionMode.Single,
                TextColor = OxyColors.White,
                FontSize = 10,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:#,##0.00}"


            };
            model.Series.Add(barSeries);


            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                AxislineColor = OxyColor.Parse("#646471"),
                TextColor = OxyColor.Parse("#646471"),
                TicklineColor = OxyColor.Parse("#646471"),

                ItemsSource = new[]
                    {
                        "janeiro",
                        "fevereiro",
                        "março",
                        "abril",
                        "maio",
                        "junho",
                        "julho",
                        "agosto",
                        "setembro",
                        "outubro",
                        "novembro",
                        "dezembro"
                    }
            });

            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                IsAxisVisible = false
            });

            return model;
        }

		public static PlotModel SerproSeriesMes(string titulo)
		{

			var model = new PlotModel();

			model.PlotAreaBackground = OxyPlot.OxyColor.Parse("#F5F9E7");
			model.SelectionColor = OxyColors.Red;
			model.PlotAreaBorderColor = OxyColor.Parse("#646471");
			model.Title = titulo;
			model.TitleColor = OxyColor.Parse("#646471");
			model.LegendPosition = LegendPosition.RightMiddle;
			model.LegendPlacement = LegendPlacement.Inside;
			model.LegendTextColor = OxyColors.White;
			model.IsLegendVisible = true;

			//generate a random percentage distribution between the 5
			//cake-types (see axis below)
			var rand = new Random();


            List<BarItem> lista = new List<BarItem>();

			for (int i = 0; i < 31; ++i)
			{
                lista.Add(new BarItem { Value = rand.Next(33000, 60000) });
			}

			var barSeries = new BarSeries
			{
				ItemsSource = lista,
				FillColor = OxyColor.Parse("#646471"),
				SelectionMode = SelectionMode.Single,
				TextColor = OxyColors.White,
				FontSize = 6,
				LabelPlacement = LabelPlacement.Inside,
				LabelFormatString = "{0:#,##0}"
			};

			model.Series.Add(barSeries);


			model.Axes.Add(new CategoryAxis
			{
				Position = AxisPosition.Left,
				AxislineColor = OxyColor.Parse("#646471"),
				TextColor = OxyColor.Parse("#646471"),
				TicklineColor = OxyColor.Parse("#646471")

			});

			model.Axes.Add(new CategoryAxis
			{
				Position = AxisPosition.Bottom,
				IsAxisVisible = false
			});

			return model;
		}


		public static PlotModel BarSeries_grouped()
        {
            var model = new PlotModel
            {
                Title = "BarSeries",
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.BottomCenter,
                LegendOrientation = LegendOrientation.Horizontal,
                LegendBorderThickness = 0
            };

            var s1 = new BarSeries { Title = "Series 1", StrokeColor = OxyColors.Black, StrokeThickness = 1 };
            s1.Items.Add(new BarItem { Value = 25 });
            s1.Items.Add(new BarItem { Value = 137 });
            s1.Items.Add(new BarItem { Value = 18 });
            s1.Items.Add(new BarItem { Value = 40 });

            var s2 = new BarSeries { Title = "Series 2", StrokeColor = OxyColors.Black, StrokeThickness = 1 };
            s2.Items.Add(new BarItem { Value = 12 });
            s2.Items.Add(new BarItem { Value = 14 });
            s2.Items.Add(new BarItem { Value = 120 });
            s2.Items.Add(new BarItem { Value = 26 });

            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
            categoryAxis.Labels.Add("Category A");
            categoryAxis.Labels.Add("Category B");
            categoryAxis.Labels.Add("Category C");
            categoryAxis.Labels.Add("Category D");
            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, MinimumPadding = 0, MaximumPadding = 0.06, AbsoluteMinimum = 0 };
            model.Series.Add(s1);
            model.Series.Add(s2);
            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);
            return model;
        }

    }
}