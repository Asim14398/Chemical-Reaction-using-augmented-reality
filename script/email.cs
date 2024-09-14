using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using EasyUI.Toast;
using UnityEngine.Windows;

public class email : MonoBehaviour
{
    public InputField inputData; // Reference to your input field
    private string url = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSfzVCqAPtLKWspEvGBGliQJwQB3WCt3mvdyZ7Spc7lopjj0FA/formResponse"; // google form link

    public void SendDataToGoogle()
    {
        if (string.IsNullOrWhiteSpace(inputData.text))
        {
            Toast.Show("This field cannot be empty.");
        }
        else
        {
            StartCoroutine(PostDataToGoogle());
        }
    }

    IEnumerator PostDataToGoogle()
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.735504572", inputData.text); // "entry.number" with the actual field name from your Google Form

        UnityWebRequest request = UnityWebRequest.Post(url, form);
        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Data sent successfully!");
            Toast.Show("FeedBack submitted");
            inputData.text = string.Empty;
        }
        else
        {
            Debug.LogError("Error sending data: " + request.error);
            Toast.Show("Please check your internet connection");
        }
    }

   
}

