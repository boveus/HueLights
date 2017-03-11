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
            if (RadioButtonList1.SelectedValue == "LivingRoom")
            {
                LivingRoomLight(json);
            }
            else
            if (RadioButtonList1.SelectedValue == "Hallway")
            {
                HallwayLight(json);
            }
        }

        protected void OnButton_Click1(object sender, EventArgs e)
        {
            string json = "{\"on\":true}";
            if (RadioButtonList1.SelectedValue == "LivingRoom")
                {
                    LivingRoomLight(json);
                }
            else 
            if (RadioButtonList1.SelectedValue == "Hallway")
                {
                    HallwayLight(json);
                }
        }
        protected void OffButton_Click1(object sender, EventArgs e)
        {
            string json = "{\"on\":false}";
                if (RadioButtonList1.SelectedValue == "LivingRoom")
                {
                    LivingRoomLight(json);
                }
                else
                if (RadioButtonList1.SelectedValue == "Hallway")
                {
                    HallwayLight(json);
                }
        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public static void LivingRoomLight(string json)
        {
            byte[] jsonbytes = Encoding.ASCII.GetBytes(json);
            using (var client = new System.Net.WebClient())
            {
                client.UploadData(new Uri("http://192.168.1.2/api/VTNCDYBr0umn6-sZEzgte7A7zED3SgfE-0RxsNy6/lights/3/state"), "PUT", jsonbytes);
                client.UploadData(new Uri("http://192.168.1.2/api/VTNCDYBr0umn6-sZEzgte7A7zED3SgfE-0RxsNy6/lights/4/state"), "PUT", jsonbytes);
                client.UploadData(new Uri ("http://192.168.1.2/api/VTNCDYBr0umn6-sZEzgte7A7zED3SgfE-0RxsNy6/lights/5/state"), "PUT", jsonbytes);
            }
        }
        public static void HallwayLight(string json)
        {
            byte[] jsonbytes = Encoding.ASCII.GetBytes(json);
            using (var client = new System.Net.WebClient())
            {
                client.UploadData(new Uri("http://192.168.1.2/api/VTNCDYBr0umn6-sZEzgte7A7zED3SgfE-0RxsNy6/lights/6/state"), "PUT", jsonbytes);
            }
        }
    }
}