﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Chungus
{
    //This class houses the data for a single level so it can be saved and edited
    class Level
    {
        //Fields
        private List<Platform> platforms = new List<Platform>(100);
        private List<Carrot> carrots = new List<Carrot>(100);
        private List<Spike> spikes = new List<Spike>(100);
        private List<Spring> springs = new List<Spring>(100);
        private List<List<int>> platformPositions = new List<List<int>>();
        private List<List<int>> carrotPositions = new List<List<int>>();
        private List<List<int>> spikePositions = new List<List<int>>();
        private List<List<int>> springPositions = new List<List<int>>();
        private List<int> InventoryItems = new List<int>();
        private int playerSpawnX;
        private int playerSpawnY;

        public List<List<int>> CarrotPositions { get => carrotPositions; set => carrotPositions = value; }
        public List<List<int>> PlatformPositions { get => platformPositions; set => platformPositions = value; }
        internal List<Carrot> Carrots { get => carrots; set => carrots = value; }
        internal List<Platform> Platforms { get => platforms; set => platforms = value; }
        public int PlayerSpawnX { get => playerSpawnX; set => playerSpawnX = value; }
        public int PlayerSpawnY { get => playerSpawnY; set => playerSpawnY = value; }

        public Level()
        {

        }

        public Level(int playerX, int playerY, List<Platform> newPlatforms, List<Carrot> newCarrots, List<Spike> newSpikes, List<Spring> newSprings, List<int> newInv)
        {
            playerSpawnX = playerX;
            playerSpawnY = playerY;
            platformPositions.Add(new List<int>(100));
            platformPositions.Add(new List<int>(100));
            carrotPositions.Add(new List<int>(100));
            carrotPositions.Add(new List<int>(100));
            spikePositions.Add(new List<int>(100));
            spikePositions.Add(new List<int>(100));
            springPositions.Add(new List<int>(100));
            springPositions.Add(new List<int>(100));

            for (int i = 0; i < newPlatforms.Count; i++)
            {
                AddObject(newPlatforms[i]);
            }
            for (int i = 0; i < newCarrots.Count; i++)
            {
                AddObject(newCarrots[i]);
            }
            for (int i = 0; i < newCarrots.Count; i++)
            {
                AddObject(newCarrots[i]);
            }
            for (int i = 0; i < newSpikes.Count; i++)
            {
                AddObject(newSpikes[i]);
            }
            for (int i = 0; i < newSprings.Count; i++)
            {
                AddObject(newSprings[i]);
            }
            for (int i = 0; i < 6; i++)
            {
                InventoryItems.Add(newInv[i]);
            }
        }

        public void AddObject(GameObject newObject)
        {
            if (newObject is Platform)
            {
                platforms.Add((Platform)newObject);
                platformPositions[0].Add(newObject.XPos);
                platformPositions[1].Add(newObject.YPos);
            }
            else if (newObject is Carrot)
            {
                carrots.Add((Carrot)newObject);
                carrotPositions[0].Add(newObject.XPos);
                carrotPositions[1].Add(newObject.YPos);
            }
            else if (newObject is Spike)
            {
                spikes.Add((Spike)newObject);
                spikePositions[0].Add(newObject.XPos);
                spikePositions[1].Add(newObject.YPos);
            }
            else if (newObject is Spring)
            {
                springs.Add((Spring)newObject);
                springPositions[0].Add(newObject.XPos);
                springPositions[1].Add(newObject.YPos);
            }
        }
    }
}
