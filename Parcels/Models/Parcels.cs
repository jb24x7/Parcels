using System.Collections.Generic;
namespace Parcels.Models
{
  public class Parcels 
  {

    public int Volume { get; set; }
    public int Weight { get; set; }

    public Parcels(int volume, int weight){
      Volume = volume;
      Weight = weight;
    }

    public int getVolume(int height, int width, int length )
    {
    return height * width * length;

    }

    public double CostToShip()
    {
      return (Volume * Weight) * .005;
    }

  }
}