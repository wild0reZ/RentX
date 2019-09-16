﻿using App.Models.Image;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Foto
{
    public interface IFotoService
    {   
        //upload delle immagini di un annuncio
        Task UploadAdImagesAsync(int idAnn, string imageAsBase64);

        //fetch delle immagini di un annuncio
        Task<List<ImageModel>> GetAdImagesAsync(int idAnn);

        //upload dell'immagine di un utente 
        Task UploadUserImageAsync(string imageAsBase64);

        //fetch dell'immagine di un utente
        Task<ImageModel> GetUserImage(int idUser);
    }
}