//Jeremy Lapham
//10-27-22
//Resturant Picker - Endpoint
//This program has a few different options for which type they want and will pick randomly which resturant to go to
//Peer Review: 
using Microsoft.AspNetCore.Mvc;

namespace LaphamJResturantPicker_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ResturantPickerController : ControllerBase
{
    [HttpGet]
    [Route("ResturantPicker/{resturantType}")]

    public string ResturantPicker(string resturantType)
    {
        string text = "";
        if (resturantType == "fastfood")
        {
            Random rndNum = new Random();
            int rndNum2 = rndNum.Next(1, 10);
            switch (rndNum2)
            {
                case 1: text = "Go to Wendy's"; break;
                case 2: text = "Go to Burger King"; break;
                case 3: text = "Go to McDonalds"; break;
                case 4: text = "Go to Jack In A Box"; break;
                case 5: text = "Go to Five Guys"; break;
                case 6: text = "Go to Dawg E's Hot Dogs"; break;
                case 7: text = "Go to Ssong's Hotdog"; break;
                case 8: text = "Go to Hob Nob Hot Dogs"; break;
                case 9: text = "Go to Dad's Hot Dogs"; break;
                case 10: text = "Go to Wienerschnitzel"; break;
            }
        }
        else if (resturantType == "sitdownplace")
        {
            Random rndNum = new Random();
            int rndNum2 = rndNum.Next(1, 10);
            switch (rndNum2)
            {
                case 1: text = "Go to Mastro's Steakhouse"; break;
                case 2: text = "Go to Ruth's Chris Steak House"; break;
                case 3: text = "Go to Le Papillon"; break;
                case 4: text = "Go to Providence"; break;
                case 5: text = "Go to Canlis"; break;
                case 6: text = "Go to Denny's"; break;
                case 7: text = "Go to Olive Garden"; break;
                case 8: text = "Go to Apple Bees"; break;
                case 9: text = "Go to Chili's"; break;
                case 10: text = "Go to BJ's"; break;
            }
        }
        else if (resturantType == "buffet")
        {
            Random rndNum = new Random();
            int rndNum2 = rndNum.Next(1, 10);
            switch (rndNum2)
            {
                case 1: text = "Go to Sherman's 2 Chinese Buffet"; break;
                case 2: text = "Go to Sushi House Buffet Chinese & Japanese Grill"; break;
                case 3: text = "Go to Wild Chinese Buffet"; break;
                case 4: text = "Go to Four Seasons Buffet"; break;
                case 5: text = "Go to Korean BBQ"; break;
                case 6: text = "Go to Hometown Buffet"; break;
                case 7: text = "Go to Golden Corral Buffet & Grill"; break;
                case 8: text = "Go to Milpitas Buffet"; break;
                case 9: text = "Go to Kinder's"; break;
                case 10: text = "Go to Hometown BBQ & Seafood"; break;
            }
        }
        else
        {
            text = "That wasn't an option. The options are 'fastfood', 'sitdownplace', or 'buffet'";
        }
        return text;
    }
}
