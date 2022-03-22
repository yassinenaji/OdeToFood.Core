using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core
{
    public partial class Restaurant
    {
        public enum CuisineType
        {
            /*[Display(Name = "None")]*/
            none,
            /*[Display(Name = "Italian")]*/
            Italian,
            /*[Display(Name = "Indian")]*/
            Indian,
           /* [Display(Name = "Moroccan")]*/
            Moroccan,


        }

    }
}
