﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SkiaSharp;
using Android.Graphics;

namespace AppTest.Model
{
    public class Monster
    {
        // private Bitmap bg;
        private Bitmap[] bodyParts;
        private int[] images;

        public Monster(ShoppingBasket shoppingBasket)
        {
            images = new int[] { Resource.Drawable.water, Resource.Drawable.flump, Resource.Drawable.haribobears, Resource.Drawable.bread, Resource.Drawable.redbull, Resource.Drawable.pasta, Resource.Drawable.e3 };
            bodyParts = new Bitmap[7];
            // bg = BitmapFactory.DecodeResource(Application.Context.Resources, Resource.Drawable.BackgroundSmall);
            for (int i = 0; i < 7; i++)
            {
                bodyParts[i] = BitmapFactory.DecodeResource(Application.Context.Resources, images[i]);
            }
        }

        public Bitmap[] GetImages()
        {
            return bodyParts;
        }
    }
}