using System.Collections.Generic;
namespace Parcels.Models
{
  public abstract class testAbstract
  {
    public int Weight { get; set; }
    public abstract int getVolume(int height, int width, int length);


  }
}