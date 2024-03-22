namespace Mom.Scan.Razor.Components.Components;

public partial class Ammeter
{
}

public class AmmeterModel
{
    public string IP { get; set; }
    public string Port { get; set; }
    public string Name { get; set; }
    public string ID { get; set; }
    public AmmeterTable AmmeterTable { get; set; }
}

public class AmmeterTable
{
    public double PT { get; set; }
    public double CT { get; set; }
    public double _03F { get; set; }
    public double _40H { get; set; }
    public double AA { get; set; }
    public double AB { get; set; }
    public double AC { get; set; }
    public double VA { get; set; }
    public double VB { get; set; }
    public double VC { get; set; }
    public double PowerA => AA * VA;
    public double PowerB => AB * VB;
    public double PowerC => AC * VC;
    public double PowerTotal => PowerA + PowerB + PowerC;
    public double PW => _03F * 65536 + _40H / 1000 * PT * CT;
}
