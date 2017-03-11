using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebForm
{
    public partial class Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SetBrightness(object sender, EventArgs e)
        {
            string brightness = BrightnessValue.Text; 
            string json = "{\"bri\": " + brightness + "}";
            string HueURL = "YourHUEURLhere";
            if (RadioButtonList1.SelectedValue == "LivingRoom")
            {
                LivingRoomLight(json, HueURL);
            }
            else
            if (RadioButtonList1.SelectedValue == "Hallway")
            {
                HallwayLight(json, HueURL);
            }
        }

        protected void OnButton_Click1(object sender, EventArgs e)
        {
            string json = "{\"on\":true}";
            string HueURL = "YourHUEURLhere";
            if (RadioButtonList1.SelectedValue == "LivingRoom")
                {
                    LivingRoomLight(json, HueURL);
                }
            else 
            if (RadioButtonList1.SelectedValue == "Hallway")
                {
                    HallwayLight(json, HueURL);
                }
        }
        protected void OffButton_Click1(object sender, EventArgs e)
        {
            string json = "{\"on\":false}";
            string HueURL = "YourHUEURLhere";
            if (RadioButtonList1.SelectedValue == "LivingRoom")
                {
                    LivingRoomLight(json, HueURL);
                }
                else
                if (RadioButtonList1.SelectedValue == "Hallway")
                {
                    HallwayLight(json, HueURL);
                }
        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static void LivingRoomLight(string json, string HueURL)
        {
            byte[] jsonbytes = Encoding.ASCII.GetBytes(json);
            using (var client = new System.Net.WebClient())
            {
                client.UploadData(new Uri(HueURL + "/lights/3/state"), "PUT", jsonbytes);
                client.UploadData(new Uri(HueURL + "/lights/4/state"), "PUT", jsonbytes);
                client.UploadData(new Uri (HueURL + "/lights/5/state"), "PUT", jsonbytes);
            }
        }
        public static void HallwayLight(string json, string HueURL)
        {
            byte[] jsonbytes = Encoding.ASCII.GetBytes(json);
            using (var client = new System.Net.WebClient())
            {
                client.UploadData(new Uri(HueURL + "/lights/6/state"), "PUT", jsonbytes);
            }
        }
    }
}