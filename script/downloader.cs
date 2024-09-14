using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.Toast;

public class downloader : MonoBehaviour
{

    public Texture2D imageToSave; // Assign this in the Inspector

    public void SaveImageToGallery()
    {
        Texture2D uncompressedTexture = new Texture2D(imageToSave.width, imageToSave.height, TextureFormat.RGBA32, false);

        // Copy the data from the compressed texture to the uncompressed texture
        Color[] pixels = imageToSave.GetPixels();
        uncompressedTexture.SetPixels(pixels);
        uncompressedTexture.Apply();

        // Convert the Texture2D to a byte array
        byte[] imageData = uncompressedTexture.EncodeToPNG();

        // Save the image to the native gallery
        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(imageData, "MyAlbum", "MyImage.png");

        // Check for permission and handle accordingly
        Debug.Log("Permission result: " + permission);
        Toast.Show("Downloaded");
    }
    public Texture2D imageToSave1; // Assign this in the Inspector

    public void SaveImageToGallery1()
    {
        Texture2D uncompressedTexture = new Texture2D(imageToSave1.width, imageToSave1.height, TextureFormat.RGBA32, false);

        // Copy the data from the compressed texture to the uncompressed texture
        Color[] pixels = imageToSave1.GetPixels();
        uncompressedTexture.SetPixels(pixels);
        uncompressedTexture.Apply();

        // Convert the Texture2D to a byte array
        byte[] imageData = uncompressedTexture.EncodeToPNG();

        // Save the image to the native gallery
        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(imageData, "MyAlbum", "MyImage.png");

        // Check for permission and handle accordingly
        Debug.Log("Permission result: " + permission);
        Toast.Show("Downloaded");
    }
    public Texture2D imageToSave2; // Assign this in the Inspector

    public void SaveImageToGallery2()
    {
        Texture2D uncompressedTexture = new Texture2D(imageToSave2.width, imageToSave2.height, TextureFormat.RGBA32, false);

        // Copy the data from the compressed texture to the uncompressed texture
        Color[] pixels = imageToSave2.GetPixels();
        uncompressedTexture.SetPixels(pixels);
        uncompressedTexture.Apply();

        // Convert the Texture2D to a byte array
        byte[] imageData = uncompressedTexture.EncodeToPNG();

        // Save the image to the native gallery
        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(imageData, "MyAlbum", "MyImage.png");

        // Check for permission and handle accordingly
        Debug.Log("Permission result: " + permission);
        Toast.Show("Downloaded");
    }
    public Texture2D imageToSave3; // Assign this in the Inspector

    public void SaveImageToGallery3()
    {
        Texture2D uncompressedTexture = new Texture2D(imageToSave3.width, imageToSave3.height, TextureFormat.RGBA32, false);

        // Copy the data from the compressed texture to the uncompressed texture
        Color[] pixels = imageToSave3.GetPixels();
        uncompressedTexture.SetPixels(pixels);
        uncompressedTexture.Apply();

        // Convert the Texture2D to a byte array
        byte[] imageData = uncompressedTexture.EncodeToPNG();

        // Save the image to the native gallery
        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(imageData, "MyAlbum", "MyImage.png");

        // Check for permission and handle accordingly
        Debug.Log("Permission result: " + permission);
        Toast.Show("Downloaded");
    }
    public Texture2D imageToSave4; // Assign this in the Inspector

    public void SaveImageToGallery4()
    {
        Texture2D uncompressedTexture = new Texture2D(imageToSave4.width, imageToSave4.height, TextureFormat.RGBA32, false);

        // Copy the data from the compressed texture to the uncompressed texture
        Color[] pixels = imageToSave4.GetPixels();
        uncompressedTexture.SetPixels(pixels);
        uncompressedTexture.Apply();

        // Convert the Texture2D to a byte array
        byte[] imageData = uncompressedTexture.EncodeToPNG();

        // Save the image to the native gallery
        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(imageData, "MyAlbum", "MyImage.png");

        // Check for permission and handle accordingly
        Debug.Log("Permission result: " + permission);
        Toast.Show("Downloaded");
    }
}
