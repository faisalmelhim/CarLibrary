using CarLibrary;

Engine engine = new (4, 210);
Car ford = new ("Ford", "Fiesta", 2016, engine);

ford.Drive();
ford.Stop();