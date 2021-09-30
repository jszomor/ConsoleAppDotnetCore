using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  public delegate void PriceChangeHandler(decimal oldPrice, decimal newPrice);

  public class EventPractice
  {
    public static event PriceChangeHandler PriceChanged;

    private static decimal _price;

    public static decimal Price
    {
      get { return _price; }
      set
      {
        if (_price == value) return;
        decimal oldPrice = _price;
        _price = value;

        //if (PriceChanged != null)
        //{
        //  PriceChanged(oldPrice, _price);
        //}

        PriceChanged?.Invoke(oldPrice, _price); // same as above
      }
    }

    public static string Call(decimal InputPrice, string symbol)
    {
      Price = InputPrice;

      string currency = $"{Price}{symbol}";

      return currency;
    }
  }
}
