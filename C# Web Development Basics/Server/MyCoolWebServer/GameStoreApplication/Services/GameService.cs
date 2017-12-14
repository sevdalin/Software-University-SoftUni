﻿namespace MyCoolWebServer.GameStoreApplication.Services
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Data;
    using Data.Models;
    using ViewModels.Admin;
    using System.Linq;

    public class GameService : IGameService
    {
        public void Create(string title, string description, byte[] image, decimal price, double size, string videoId,
            DateTime releaseDate)
        {
            using (var db = new GameStoreDbContext())
            {
                var game = new Game
                {
                    Title = title,
                    Description = description,
                    Image = image,
                    Price = price,
                    Size = size,
                    VideoId = videoId,
                    ReleaseDate = releaseDate
                };

                db.Games.Add(game);
                db.SaveChanges();
            }
        }

        public IEnumerable<AdminListGameViewModel> All()
        {
            using (var db = new GameStoreDbContext())
            {
                return db.Games
                    .Select(g => new AdminListGameViewModel
                    {
                        Id = g.GameId,
                        Name = g.Title,
                        Price = g.Price,
                        Size = g.Size
                    })
                    .ToList();
            }
        }
    }
}