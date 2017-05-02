namespace ChartsExample.Axes
{
    using OxyPlot;
    using OxyPlot.Axes;

    public class PolarPlotExamples
    {
        public static PlotModel Default()
        {
            var model = new PlotModel { Title = "AngleAxis and MagnitudeAxis", PlotType = PlotType.Polar };
            model.Axes.Add(new AngleAxis { Title = "Angle" });
            model.Axes.Add(new MagnitudeAxis { Title = "Magnitude" });
            return model;
        }
    }
}