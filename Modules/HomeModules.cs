using Nancy;
using System.Collections.Generic;
using CarDealership.Objects;

namespace CarDealership
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];
      Get["/view_all_car"] = _ => {
        List<string> allcar = Car.GetAll();
        return View["view_all_car.cshtml", allcar];
      };
      Post["/car_added"] = _ => {
        Car newcar = new Car (Request.Form["new-model"], Request.Form["new-price"], Request.Form["new-miles"]);
        newcar.Save();
        return View["car_added.cshtml", newcar];
      };
      Post["/car_cleared"] = _ => {
        Car.ClearAll();
        return View["car_cleared.cshtml"];
      };
    }
  }
}
