namespace ShowList.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShowList.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShowList.Models.ApplicationDbContext context)
        {
            #region Shows
            context.Shows.AddOrUpdate(
                p => p.ShowID,
            
                new Show
                {
                    ShowID = 0001,
                    Name = "24",
                    Network = "20th Century Fox",
                    PrimaryGenre = "Action",
                    SencondaryGenre = "Drama",
                    RunYears = "(2001–2010)",
                    Summary = "In this concept drama, each season takes place within one 24 hour period. Day 1: Jack Bauer is the head of field ops for an elite team of CTU agents who uncover an assassination plot targeting Presidential nominee David Palmer. Meanwhile, Jack's strained marriage to his wife, Teri, is pushed to the brink by the sudden disappearance of their troubled teenage daughter. What will the next 24 hours hold?",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 195,
                },
                new Show
                {
                    ShowID = 0002,
                    Name = "Archer",
                    Network = "FX",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Comedy",
                    RunYears = "(2009– )",
                    Summary = "Covert black ops and espionage take a back seat to zany personalities and relationships between secret agents and drones.",
                    Status = "Hiatus",
                    Rating = "TV-MA ",
                    TotalEp = 93,
                },
                new Show
                {
                    ShowID = 0003,
                    Name = "Arrested Development",
                    Network = "20th Century Fox",
                    PrimaryGenre = "Comedy",
                    RunYears = "(2003– )",
                    Summary = "Michael Bluth finds himself forced to stay in Orange County and run the family real estate business after his father, George Bluth Sr., is sent to prison for committing white-collar crime. He tries to juggle the wants and needs of his spoiled and eccentric family while being a good role model for his teenage son, George Michael.",
                    Status = "Hiatus",
                    Rating = "TV-PG",
                    TotalEp = 85,
                },
                new Show
                {
                    ShowID = 0004,
                    Name = "Avatar: The Last Airbender",
                    Network = "Nickelodeon",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Action",
                    RunYears = "(2005–2008)",
                    Summary = "The world is divided into four nations -- the Water Tribe, the Earth Kingdom, the Fire Nation and and the Air Nomads -- each represented by a natural element for which the nation is named. Benders have the ability to control and manipulate the element from their nation. Only the Avatar is the master of all four elements. The ruthless Fire Nation wants to conquer the world but the only bender who has enough power, the Avatar, has disappeared ... until now. His tribe soon discovers that Aang is the long-lost Avatar. Now Katara and Sokka must safeguard Aang on his journey to master all four elements and save the world from the Fire Nation.",
                    Status = "Complete",
                    Rating = "TV-Y7",
                    TotalEp = 62,
                },
                new Show
                {
                    ShowID = 0005,
                    Name = "Band Of Brothers",
                    Network = "HBO",
                    PrimaryGenre = "War",
                    SencondaryGenre = "History",
                    RunYears = "(2001)",
                    Summary = "This series, originally broadcast on HBO, tells the story of Easy Company, 506th Regiment of the 101st Airborne Division, U.S. Army. Based on interviews with survivors of Easy Company, as well as soldiers' journals and letters, this 10-part series chronicles the experiences of these young men who knew extraordinary bravery and extraordinary fear. Based on the book written by Stephen Ambrose.",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 10,
                },
                new Show
                {
                    ShowID = 0006,
                    Name = "Banshee",
                    Network = "Cinemax",
                    PrimaryGenre = "Action",
                    SencondaryGenre = "Drama",
                    RunYears = "(2013–2016)",
                    Summary = "A recently paroled master thief assumes the identity of Sheriff Lucas Hood in Banshee, Pa., where his former lover and partner in crime relocated years ago and reinvented herself as Carrie Hopewell, the wife of the town's prosecutor. As Lucas attempts to reunite with Carrie and keep his past a secret, he resumes his life of crime, even as he's hunted by the shadowy gangsters he betrayed years earlier, including a mob boss who seeks revenge against Lucas and Carrie for the jewel heist that landed Lucas in prison.",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 38,
                },
                new Show
                {
                    ShowID = 0007,
                    Name = "Battlestar Galactica (2004)",
                    Network = "Syfy",
                    PrimaryGenre = "Sci-fi",
                    SencondaryGenre = "Action",
                    RunYears = "(2004–2009)",
                    Summary = "In the seventh millennium, A.D., Galactica is the only surviving battleship after an attack by the evil Cylons. As a result of the attack, peace and most of humankind have been wiped out. Led by Commander Adama, Galactica, as well as a couple hundred smaller ships flee to try to find refuge on the legendary but unknown planet Earth. The Cylons, with the help of the equally evil Count Baltar, are in hot pursuit.",
                    Status = "Complete",
                    Rating = "TV-14 ",
                    TotalEp = 73,
                },
                new Show
                {
                    ShowID = 0008,
                    Name = "Better Call Saul",
                    Network = "AMC",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = "(2015– )",
                    Summary = "He wasn't always Saul Goodman, ace attorney for chemist-turned-meth dealer Walter White. Six years before he begins to represent Albuquerque's most notorious criminal, Goodman is Jimmy McGill, a small-time attorney hustling to make a name for himself. He's a forceful champion for his low-income clients, an underdog whose morals and ambitions often clash. Jimmy works with private eye Mike Ehrmantraut, a former Philadelphia cop and recent transplant to the Southwest. Mike has a specialized skill set -- he's a 'fixer' of sticky situations -- that Jimmy soon learns to appreciate.",
                    Status = "Hiatus",
                    Rating = "TV-14",
                    TotalEp = 30,
                },
                new Show
                {
                    ShowID = 0009,
                    Name = "Black Mirror",
                    Network = "Netflix, Channel 4",
                    PrimaryGenre = "Drama",
                    SencondaryGenre = "Sci-fi",
                    RunYears = "(2011– )",
                    Summary = "Featuring stand-alone dramas -- sharp, suspenseful, satirical tales that explore techno-paranoia -- 'Black Mirror' is a contemporary reworking of 'The Twilight Zone' with stories that tap into the collective unease about the modern world. Each story features its own cast of unique characters, including stars like Bryce Dallas Howard ('The Help'), Alice Eve, Gugu Mbatha-Raw, Tom Cullen and Jerome Flynn ('Game of Thrones'). Joe Wright, Dan Trachtenberg, and James Watkins are among the featured directors.",
                    Status = "Hiatus",
                    Rating = "TV-MA",
                    TotalEp = 19,
                },
                new Show
                {
                    ShowID = 0010,
                    Name = "Breaking Bad",
                    Network = "AMC",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = " (2008–2013)",
                    Summary = "Mild-mannered high school chemistry teacher Walter White thinks his life can't get much worse. His salary barely makes ends meet, a situation not likely to improve once his pregnant wife gives birth, and their teenage son is battling cerebral palsy. But Walter is dumbstruck when he learns he has terminal cancer. Realizing that his illness probably will ruin his family financially, Walter makes a desperate bid to earn as much money as he can in the time he has left by turning an old RV into a meth lab on wheels.",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 62,
                },
                new Show
                {
                    ShowID = 0011,
                    Name = "Broadchurch",
                    Network = "ITV",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = "(2013– )",
                    Summary = "When the corpse of an 11-year-old British boy, Danny Latimer, is found bloodied and dirty on an idyllic beach, a small Dorset community becomes the focus of a police investigation and media madness. Out-of-town Detective Inspector Alec Hardy gets the point position over Detective Sgt. Ellie Miller -- who feels the job should have been hers. Now she must engage in an efficient working relationship with taciturn Hardy. Slowly, more members of the community of Broadchurch are drawn into the investigation, with a telephone engineer drawing great attention when he admits to a special connection to the case. While dealing with so much unwelcome attention, Danny's family tries to cope with its grief. When a suspect is named and charged, the ensuing trial sees the defendant promising to expose more of the townspeople's secrets.",
                    Status = "Hiatus",
                    Rating = "TV-MA",
                    TotalEp = 24,
                },
                new Show
                {
                    ShowID = 0012,
                    Name = "Community",
                    Network = "NBC",
                    PrimaryGenre = "Comedy",
                    RunYears = "(2009–2015)",
                    Summary = "When fast-talking lawyer Jeff Winger (Joel McHale) finds his degree has been revoked, he is forced to go back to school at Greendale Community College. Hoping to score points with a pretty coed, he invents a study group and invites her to join it. Imagine his surprise when she's not the only one who shows up for help with Spanish from the 'board-certified tutor' he proclaims himself to be. Though his command of the language is anything but good, the members continue to meet and end up learning a lot about themselves.",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 110,
                },
                new Show
                {
                    ShowID = 0013,
                    Name = "Cosmos: A Spacetime Odyssey",
                    Network = "National Geographics",
                    PrimaryGenre = "Documentary",
                    RunYears = "(2014)",
                    Summary = "'Family Guy' creator Seth MacFarlane, in a departure from the type of material he is best known for, pays homage to Carl Sagan's award-winning and iconic 'Cosmos' with this docuseries. Through stories of humankind's quest for knowledge, viewers travel across the universe. Scientific concepts are presented clearly, with both skepticism and wonder, to impart their full impact. Renowned astrophysicist Neil deGrasse Tyson hosts, and Sagan's original creative collaborator, Ann Druyan, serves as an executive producer.",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 13,
                },
                new Show
                {
                    ShowID = 0014,
                    Name = "Daredevil",
                    Network = "Netflix",
                    PrimaryGenre = "Action",
                    SencondaryGenre = "Crime",
                    RunYears = "(2015– )",
                    Summary = "The first in a planned series of shows detailing the Marvel universe, 'Daredevil' follows Matt Murdock, attorney by day and vigilante by night. Blinded in an accident as a child, Murdock uses his heightened senses as Daredevil to fight crime on the streets of New York after the sun goes down. While Murdock's day job requires him to believe in the criminal justice system, his alter ego does not follow suit, leading him to take the law into his own hands to protect his Hell's Kitchen neighborhood and the surrounding communities.",
                    Status = "Hiatus",
                    Rating = "TV-MA",
                    TotalEp = 27,
                },
                new Show
                {
                    ShowID = 0015,
                    Name = "Dexter",
                    Network = "Showtime",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Mystery",
                    RunYears = "(2006–2013)",
                    Summary = "Dexter Morgan is a Miami-based blood splatter expert who doesn't just solve murders; he commits them too. In fact, he's a serial killer -- but he only murders the guilty, so he feels justified with his lifestyle choices. His policewoman sister and his cop co-workers have no idea Dexter lives a double life; however, adoptive father Harry knows his secret, and does, in fact, help Dexter hone his 'skills.' It's a unique brand of justice for which charming Dexter feels a psychological hunger.",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 96,
                },
                new Show
                {
                    ShowID = 0016,
                    Name = "Doctor Who (2005)",
                    Network = "BBC",
                    PrimaryGenre = "Adventure",
                    SencondaryGenre = "Sci-fi",
                    RunYears = "(2005– )",
                    Summary = "'Doctor Who' is a classic science-fiction series with a cult following. The Doctor is called a 'Time Lord,' a time-traveling scientist from a far off planet, who travels through time and space in a shop known by the acronym TARDIS. A TARDIS is a machine that is larger on the inside than the outside and is supposed to change its appearance based on its surroundings. The Doctor is also able to evolve his biology, so he appears as many different people throughout the series. The Doctor loves Earth, so he makes many trips here to save the planet, or to enlist earthlings to help him with tasks in the galaxy.",
                    Status = "Hiatus",
                    Rating = "TV-PG",
                    TotalEp = 161,
                },
                new Show
                {
                    ShowID = 0017,
                    Name = "Downton Abbey",
                    Network = "ITV",
                    PrimaryGenre = "Drama",
                    SencondaryGenre = "Romance",
                    RunYears = "(2010–2015)",
                    Summary = "Lord Grantham sees his family heritage, especially the grand country home Downton Abbey, as his mission in life. The death of his heir aboard the Titanic means distant cousin Matthew Crawley, a Manchester lawyer, suddenly is next in line and accepts moving onto the vast estate with his even more modernist, socially engaged mother, who clashes with his lordship's domineering, conservative mother, the dowager countess. Marrying off the daughters is another concern. Meanwhile, the butler presides over a staff which serves the family, but also lead most of their entire lives in the servants' quarters, intriguing amongst themselves. ",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 52,
                },
                new Show
                {
                    ShowID = 0018,
                    Name = "Dragon Ball Z",
                    Network = "Toei Animation",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Action",
                    RunYears = "(1996–2003)",
                    Summary = "In the version that is shown on YTV in Canada, the story begins mid-way through the Dragon Ball Z series. Raditz, Goku's brother has traveled to Earth to find out why Goku has not yet destroyed the planet as he was supposed to do. But while as a baby, Goku was dropped (down a huge cliff) and forgot his real mission. Kakarot, Goku's real name battles his brother Raditzs along with former enemy Piccolo and friend Krillin. Meanwhile, Gohan; Goku's son reveals his hidden powers against Raditz and nearly kills Raditz. However Goku is killed in the end, but Raditz is eventually defeated by Piccolo. Before he dies, he tells them that two evil Saiyans even more powerful then he is, are on route to Earth. The remaining fighters, Krillin, Yamcha, Tien, and Chiaotzu begin their training to battle the evil Saiyans, while Piccolo takes off with Gohan to train him in using his new found power. Meanwhile, Goku has to make his way back on Snake Way to King Kai's where he trains himself in the secret ... ",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 277,
                },
                new Show
                {
                    ShowID = 0019,
                    Name = "Firefly",
                    Network = "20th Century Fox",
                    PrimaryGenre = "Adventure",
                    SencondaryGenre = "Sci-fi",
                    RunYears = "(2002–2003)",
                    Summary = "Set 500 years in the future after a universal civil war, the crew of a small transport spaceship takes any job so long as it puts food on the table. The disparate men and women just want to survive and maybe have better lives, but they face constant challenges on the new frontier, such as the Reavers -- flesh-eating mongrels who live on the fringes of the universe.",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 14,
                },
                new Show
                {
                    ShowID = 0020,
                    Name = "Friends",
                    Network = "Warner Bros",
                    PrimaryGenre = "Comedy",
                    SencondaryGenre = "Romance",
                    RunYears = "(1994–2004)",
                    Summary = "Three young men and three young women - of the BFF kind - live in the same apartment complex and face life and love in New York. They're not above sticking their noses into one another's businesses and swapping romantic partners, which always leads to the kind of hilarity average people will never experience - especially during breakups.",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 236,
                },
                new Show
                {
                    ShowID = 0021,
                    Name = "Fringe",
                    Network = "20th Century Fox",
                    PrimaryGenre = "Mystery",
                    SencondaryGenre = "Drama",
                    RunYears = "(2008–2013)",
                    Summary = "FBI Special Agent Olivia Dunham is assigned to the bureau's Fringe Division, in which she investigates unusual crimes and occurrences. Assisting Olivia in her investigations are once-institutionalized scientist Dr. Walter Bishop, his jack-of-all-trades son, Peter, and FBI Junior Agent Astrid Farnsworth. As the team investigates cases of science gone awry, they discover connections to their own past and to a parallel universe. As the team solves cases in these interconnected worlds, new discoveries and complications continue to arise.",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 100,
                },
                new Show
                {
                    ShowID = 0022,
                    Name = "Frozen Planet",
                    Network = "BBC",
                    PrimaryGenre = "Documentary",
                    RunYears = "(2011–2012)",
                    Summary = "The team that produced the Emmy-winning 'Planet Earth' series -- the BBC Natural History Unit and Discovery Channel -- combine forces once again for this sweeping seven-part documentary. Shot entirely in high-definition and featuring cutting-edge cinematography to capture undisturbed observations of animal behavior, 'Frozen Planet' chronicles the ecosystems and animals of the Arctic and Antarctic, where the filmmakers spent more than 2,300 days in the field and 18 months at sea to record unprecedented footage. Episodes track the lives of polar bears, wolves, killer whales and penguins from the spring through the winter, and there is also a 'making of' episode that details the challenges faced by the 'Frozen Planet' team. The series is narrated by Alec Baldwin; the seventh episode -- a look at the effect global warming is having on not only the poles but also the rest of the planet -- is hosted by British naturalist Sir David Attenborough.",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 11,
                },
                new Show
                {
                    ShowID = 0023,
                    Name = "Fullmetal Alchemist",
                    Network = "Aniplex",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Action",
                    RunYears = "(2003–2004)",
                    Summary = "The Elric brothers' mother is dead and their father has long since abandoned them. Deciding to perform a forbidden human transmutation to bring their mother back, they end up losing their bodies. Now Edward must join the military in order to gain certain alchemical privileges, with his one goal being to restore his brother to his original state. But with war on the horizon it's only a matter of time before they are both forced to question their morals and ultimately decide the value of human life.",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 51,
                },
                new Show
                {
                    ShowID = 0024,
                    Name = "Futurama",
                    Network = "20th Century Fox",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Comedy",
                    RunYears = "(1999–2013)",
                    Summary = "Phillip Fry is a 25-year-old pizza delivery boy whose life is going nowhere. When he accidentally freezes himself on December 31, 1999, he wakes up 1,000 years in the future and has a chance to make a fresh start. He goes to work for the Planet Express Corporation, a futuristic delivery service that transports packages to all five quadrants of the universe. His companions include the delivery ship's captain, Leela, a beautiful one-eyed female alien who kicks some serious butt, and Bender, a robot with very human flaws.",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 124,
                },
                new Show
                {
                    ShowID = 0025,
                    Name = "Game Of Thrones",
                    Network = "HBO",
                    PrimaryGenre = "Adventure",
                    SencondaryGenre = "Fantasy",
                    RunYears = "(2011– )",
                    Summary = "In the mythical continent of Westeros, several powerful families fight for control of the Seven Kingdoms. As conflict erupts in the kingdoms of men, an ancient enemy rises once again to threaten them all. Meanwhile, the last heirs of a recently usurped dynasty plot to take back their homeland from across the Narrow Sea.",
                    Status = "Hiatus",
                    Rating = "TV-MA",
                    TotalEp = 73,
                },
                new Show
                {
                    ShowID = 0026,
                    Name = "Hannibal",
                    Network = "NBC",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = "(2013–2015)",
                    Summary = "Gifted criminal profiler Will Graham has a unique way of thinking that allows him to empathize with anyone, including psychopaths. But while helping the FBI pursue a particularly complicated serial killer, he decides he could use some help and enlists the brilliant psychiatrist Hannibal Lecter. The two form a partnership and it seems that there is no villain they can't catch together, but Lecter harbors a dark secret. His own brilliant mind has gone to the dark side and he has more in common with the criminals they hunt than Will could possibly imagine.",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 39,
                },
                new Show
                {
                    ShowID = 0027,
                    Name = "Homeland",
                    Network = "Showtime",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = "(2011– )",
                    Summary = "Carrie Mathison, a CIA operations officer, is on probation after carrying out an unauthorized operation in Iraq. As a result, she has been reassigned to the Counter terrorism center. Whilst in Iraq, she was warned that an American prisoner had been turned by Al-Qaeda. When Nicholas Brody, a U.S. Marine Sergeant, is rescued after being held hostage since 2003, she suspects that he is the one. While Brody is received home as a war hero, Carrie goes to any lengths necessary to catch him out.",
                    Status = "Hiatus",
                    Rating = "TV-MA",
                    TotalEp = 24,
                    NextEpisode = new DateTime(2017, 1, 15),
                },
                new Show
                {
                    ShowID = 0028,
                    Name = "House",
                    Network = "20th Century Fox",
                    PrimaryGenre = "Drama",
                    SencondaryGenre = "Mystery",
                    RunYears = "(2004–2012)",
                    Summary = "At fictional Princeton Plainsboro Teaching Hospital in New Jersey, prickly genius Dr. Gregory House tackles health mysteries as would a medical Sherlock Holmes, all the while playing mind games with colleagues that include his best friend, oncologist James Wilson. House, an acerbic infectious disease specialist, solves medical puzzles with the help of a team of young diagnosticians. Flawless instincts and unconventional thinking help earn House great respect, despite his brutal honesty and antisocial tendencies.",
                    Status = "Complete",
                    Rating = "TV-14 ",
                    TotalEp = 176,
                },
                new Show
                {
                    ShowID = 0029,
                    Name = "House of Cards",
                    Network = "Netflix",
                    PrimaryGenre = "Drama",
                    RunYears = "(2013– )",
                    Summary = "Majority House Whip Francis Underwood takes you on a long journey as he exacts his vengeance on those he feels wronged him - that is, his own cabinet members including the President of the United States himself. Dashing, cunning, methodical and vicious, Frank Underwood along with his equally manipulative yet ambiguous wife, Claire take Washington by storm through climbing the hierarchical ladder to power in this Americanized recreation of the BBC series of the same name.",
                    Status = "Hiatus",
                    Rating = "TV-MA",
                    TotalEp = 57,
                },
                new Show
                {
                    ShowID = 0030,
                    Name = "Hunter X Hunter (2011)",
                    Network = "NTV",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Action",
                    RunYears = " (2011– )",
                    Summary = "Gon Freecss is a young boy living on Whale Island. He learns from 'Hunter' Kite, that his father, who he was told was dead, is still alive somewhere as a top 'Hunter,' risking his life to seek unknown items, such as hidden treasures, curiosa, exotic living creatures, etc. Gon decides to become a professional Hunter and leaves the island. To become a Hunter, he must pass the Hunter Examination, where he meets and befriends three other applicants: Kurapika, Leorio and Killua. Can Gon pass this formidable hurdle, the Hunter Examination, to become 'the Best Hunter in the World' and eventually meet his father?",
                    Status = "Hiatus",
                    Rating = "TV-14",
                    TotalEp = 148,
                },
                new Show
                {
                    ShowID = 0031,
                    Name = "Late Week Tonight",
                    Network = "HBO",
                    PrimaryGenre = "Comedy",
                    SencondaryGenre = "Talk-show",
                    RunYears = "(2014– )",
                    Summary = "With his insightful wit and fearless candor, comedian John Oliver, formerly of the The Daily Show (1996), reviews the crazy current affairs happening in America and around the world. In doing so, he provides a wry perspective that punctures pomposity and cuts through all pretensions with comically outrageous audacity. In doing so, he can to get to the heart of the matter of the world's most serious and absurd problems with plenty of laughs along the way.",
                    Status = "Airing",
                    Rating = "TV-MA",
                    TotalEp = 91,
                },
                new Show
                {
                    ShowID = 0032,
                    Name = "The Legend of Korra",
                    Network = "Nickelodeon",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Adventure",
                    RunYears = "(2012–2014)",
                    Summary = "Taking place 70 years after the events of 'Avatar: The Last Airbender,' this story follows the adventures of the Avatar after Aang - a passionate, rebellious, and fearless teenage girl from the Southern Water Tribe named Korra. With three of the four elements under her belt (Earth, Water, and Fire), Korra seeks to master the final element, Air. Her quest leads her to the epicenter of the modern 'Avatar' world, Republic City - a metropolis that is fueled by steampunk technology. It is a virtual melting pot where benders and non-benders from all nations live and thrive. However, Korra discovers that Republic City is plagued by crime as well as a growing anti-bending revolution that threatens to rip it apart. Under the tutelage of Aang's son, Tenzin, Korra begins her airbending training while dealing with the dangers at large.",
                    Status = "Complete",
                    Rating = "TV-Y7",
                    TotalEp = 52,
                },
                new Show
                {
                    ShowID = 0033,
                    Name = "Lost",
                    Network = "ABC",
                    PrimaryGenre = "Adventure",
                    SencondaryGenre = "Drama",
                    RunYears = "(2004–2010)",
                    Summary = "Life is laid bare as a group of plane crash survivors find themselves stranded on a remote Pacific island. The trauma of the crash soon becomes overshadowed by the island itself, where unseen creatures stalk the jungle, paranormal happenings abound and astonishing coincidences reveal themselves. In this unique environment emotions swell as the survivors battle their inner and outer demons, and strive to live together - so that they won't die alone. ",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 118,
                },
                new Show
                {
                    ShowID = 0034,
                    Name = "Making a Murderer",
                    Network = "Netflix",
                    PrimaryGenre = "Documentary",
                    SencondaryGenre = "Crime",
                    RunYears = "(2015– )",
                    Summary = "Filmed over a 10-year period, Making a Murderer is an unprecedented real-life thriller about Steven Avery, a DNA exoneree who, while in the midst of exposing corruption in local law enforcement, finds himself the prime suspect in a grisly new crime. Set in America's heartland, the series takes viewers inside a high-stakes criminal case where reputation is everything and things are never as they appear.",
                    Status = "Hiatus",
                    Rating = "TV-14",
                    TotalEp = 14,
                },
                new Show
                {
                    ShowID = 0035,
                    Name = "Modern Family",
                    Network = "20th Century Fox",
                    PrimaryGenre = "Comedy",
                    SencondaryGenre = "Romance",
                    RunYears = "(2009– )",
                    Summary = "Told from the perspective of an unseen documentary filmmaker, the series offers an honest, often-hilarious perspective of family life. Parents Phil and Claire yearn for an honest, open relationship with their three kids. But a daughter who is trying to grow up too fast, another who is too smart for her own good, and a rambunctious young son make it challenging. Claire's dad, Jay, and his Latina wife, Gloria, are raising two sons together, but people sometimes believe Jay to be Gloria's father. Jay's gay son, Mitchell, and his partner, Cameron, have adopted a little Asian girl, completing one big -- straight, gay, multicultural, traditional -- happy family. ",
                    Status = "Airing",
                    Rating = "TV-PG",
                    TotalEp = 178,
                    NextEpisode = new DateTime(2016,12,15,19,0,0),
                },
                new Show
                {
                    ShowID = 0036,
                    Name = "Mr. Robot",
                    Network = "Universal",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = "(2015– )",
                    Summary = "Young, anti-social computer programmer Elliot works as a cybersecurity engineer during the day, but at night he is a vigilante hacker. He is recruited by the mysterious leader of an underground group of hackers to join their organization. Elliot's task? Help bring down corporate America, including the company he is paid to protect, which presents him with a moral dilemma. Although he works for a corporation, his personal beliefs make it hard to resist the urge to take down the heads of multinational companies that he believes are running -- and ruining -- the world.",
                    Status = "Hiatus",
                    Rating = "TV-MA",
                    TotalEp = 23,
                },
                new Show
                {
                    ShowID = 0037,
                    Name = "One Punch Man",
                    Network = "Viz Media",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Action",
                    RunYears = "(2015– )",
                    Summary = "In a world of superhuman beings, Saitama is a unique hero, he can defeat enemies with a single punch. But being just one hero in a world filled with them, his life is empty and hollow: he gets no respect from anyone, he displays a laidback attitude to everything and for the most part, he finds his overall hero life pointless... and worst of all, he lost his hair due to intense training. These are the adventures of an ordinary yet extraordinary hero.",
                    Status = "Hiatus",
                    Rating = "TV-PG",
                    TotalEp = 19,
                },
                new Show
                {
                    ShowID = 0038,
                    Name = "Parks and Recreation",
                    Network = "Universal",
                    PrimaryGenre = "Comedy",
                    RunYears = "(2009–2015)",
                    Summary = "Leslie Knope, a midlevel bureaucrat in an Indiana Parks and Recreation Department, hopes to beautify her town (and boost her own career) by helping local nurse Ann Perkins turn an abandoned construction site into a community park, but what should be a fairly simple project is stymied at every turn by oafish bureaucrats, selfish neighbors, governmental red tape and a myriad of other challenges. Leslie's colleague Tom Haverford, who delights in exploiting his position for personal gain, is as likely to undermine her efforts as to help her, while her boss, Ron Swanson, is adamantly opposed to government in any form, even though he's a bureaucrat himself.",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 125,
                },
                new Show
                {
                    ShowID = 0039,
                    Name = "Person of Interest",
                    Network = "Warner Bros",
                    PrimaryGenre = "Action",
                    SencondaryGenre = "Crime",
                    RunYears = "(2011–2016)",
                    Summary = "A billionaire software-genius named Harold Finch creates a Machine for the government that is designed to detect acts of terror before they can happen, by monitoring the entire world through every cell-phone, email and surveillance camera. Finch discovered that the machine sees everything, potential terrorist acts and violent crimes that involve ordinary people. When the government considered violent crimes between normal people 'irrelevant', Finch built a back door into the system that gives him the social security number of a person involved in a future violent crime so he could act. Partnered with John Reese, an ex-CIA agent, the two work in secret to prevent violent crimes before they can happen. Eventually their activities lead to being hunted by the New York Police Department, CIA Agents in pursuit of Reese who was listed as dead, a computer hacker named Root who wants access to the Machine, and government officials who want to keep all knowledge of the Machine a complete secret.",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 103,
                },
                new Show
                {
                    ShowID = 0040,
                    Name = "Planet Earth",
                    Network = "BBC",
                    PrimaryGenre = "Documentary",
                    SencondaryGenre = "",
                    RunYears = "(2006)",
                    Summary = "Each 50 minute episode features a global overview of a different biome or habitat on Earth (Polar, Mountain, Cave, Desert, Plains, Fresh Water, Seas, Ocean, Forest), followed by a ten-minute featurette which takes a behind-the-scenes look at the challenges of filming the episode.",
                    Status = "Complete",
                    Rating = "TV-G",
                    TotalEp = 11,
                },
                new Show
                {
                    ShowID = 0041,
                    Name = "Pride and Prejudice",
                    Network = "BBC",
                    PrimaryGenre = "Drama",
                    SencondaryGenre = "Romance",
                    RunYears = "(1995– )",
                    Summary = "Jane Austen's classic novel about the prejudice that occurred between the 19th century classes and the pride which would keep lovers apart.",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 6,
                },
                new Show
                {
                    ShowID = 0042,
                    Name = "Prison Break",
                    Network = "20th Century Fox",
                    PrimaryGenre = "Action",
                    SencondaryGenre = "Crime",
                    RunYears = "(2005–2009)",
                    Summary = "Structural Engineer Michael Scofield turns himself in to the Fox River Penitentiary in order to break out his brother Lincoln Burrows, who is on death row for the murder of the Vice President's brother. But Lincoln was set up by some of the Company (an agency formed by corrupt government officials) guys, headed by General Jonathan Krantz. Michael breaks out from Fox River with his brother Lincoln and other convicts. ",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 81,
                },
                new Show
                {
                    ShowID = 0043,
                    Name = "Rick and Morty",
                    Network = "Cartoon Network",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Comedy",
                    RunYears = "(2013– )",
                    Summary = "After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family. Although Beth welcomes Rick into her home, her husband, Jerry, isn't as happy about the family reunion. Jerry is concerned about Rick, a sociopathic scientist, using the garage as his personal laboratory. In the lab, Rick works on a number of sci-fi gadgets, some of which could be considered dangerous. But that's not all Rick does that concerns Jerry. He also goes on adventures across the universe that often involve his grandchildren, Morty and Summer.",
                    Status = "Airing",
                    Rating = "TV-14",
                    TotalEp = 35,
                    NextEpisode = new DateTime(2016,12,18,23,0,0),
                },
                new Show
                {
                    ShowID = 0044,
                    Name = "Scrubs",
                    Network = "ABC",
                    PrimaryGenre = "Comedy",
                    SencondaryGenre = "Drama",
                    RunYears = "(2001–2010)",
                    Summary = "A new group of medical students arrives to learn the ropes at Sacred Heart Hospital, where J.D., Turk, Kelso, and acerbic Dr. Cox are their instructors. J.D. continues to romance Elliot as he imparts wisdom to a new class, which includes Lucy, Drew, Cole and Maya.",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 182,
                },
                new Show
                {
                    ShowID = 0045,
                    Name = "Seinfeld",
                    Network = "NBC",
                    PrimaryGenre = "Comedy",
                    RunYears = "(1989–1998)",
                    Summary = "Jerry Seinfeld stars in this television comedy series as himself, a comedian. The premise of this sitcom is Jerry and his friends going through everyday life, discussing various quirky situations that we can all relate to (especially if we live in New York). The eccentric personalities of the offbeat characters who make up Jerry's social circle contribute to the fun. ",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 173,
                },
                new Show
                {
                    ShowID = 0046,
                    Name = "Sherlock",
                    Network = "BBC",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Mystery",
                    RunYears = "(2010– )",
                    Summary = "In this modernized version of the Conan Doyle characters, using his detective plots, Sherlock Holmes lives in early 21st century London and acts more cocky towards Scotland Yard's detective inspector Lestrade because he's actually less confident. Doctor Watson is now a fairly young veteran of the Afghan war, less adoring and more active.",
                    Status = "Hiatus",
                    Rating = "TV-14",
                    TotalEp = 15,
                },
                new Show
                {
                    ShowID = 0047,
                    Name = "Silicon Valley",
                    Network = "HBO",
                    PrimaryGenre = "Comedy",
                    RunYears = "(2014– )",
                    Summary = "In the high-tech gold rush of modern Silicon Valley, the people most qualified to succeed are the least capable of handling success. A comedy partially inspired by Mike Judge's own experiences as a Silicon Valley engineer in the late 1980s. ",
                    Status = "Hiatus",
                    Rating = "TV-MA",
                    TotalEp = 38,
                },
                new Show
                {
                    ShowID = 0048,
                    Name = "The Simpsons",
                    Network = "20th Century Fox",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Comedy",
                    RunYears = "(1989– )",
                    Summary = "The Simpsons is an animated sitcom about the antics of a dysfunctional family called the Simpsons (surprise surprise). Homer is the oafish unhealthy beer loving father, Marge is the hardworking homemaker wife, Bart is the ten year old underachiever (and proud of it), Lisa is the unappreciated eight year old genius, and Maggie is the cute, pacifier loving silent infant.",
                    Status = "Airing",
                    Rating = "TV-14",
                    TotalEp = 619,
                    NextEpisode = new DateTime (2016,12,11,9,30,0),
                },
                new Show
                {
                    ShowID = 0049,
                    Name = "Six Feet Under",
                    Network = "HBO",
                    PrimaryGenre = "Comedy",
                    SencondaryGenre = "Drama",
                    RunYears = "(2001–2005)",
                    Summary = "A drama series that takes a darkly comical look at members of a dysfunctional family that runs an independent funeral home. With the prodigal elder son (Nate) returning home for the holidays to shattering news, the family must learn to deal with a death of their own, while figuring out how to go ahead with the business of the living. A funny and emotional look at a grieving American family...that just happens to be in the grief management business.",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 63,
                },
                new Show
                {
                    ShowID = 0050,
                    Name = "Sons of Anarchy",
                    Network = "FX",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = "(2008–2014)",
                    Summary = "Sons of Anarchy, aka SAMCRO, is a motorcycle club that operates both illegal and legal businesses in the small town of Charming. They combine gun-running and a garage, plus involvement in porn film. Clay, the president, likes it old school and violent; while Jax, his stepson and the club's VP, has thoughts about changing the way things are, based on his dead father's journal. Their conflict has effects on both the club and their personal relationships.",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 92,
                },
                new Show
                {
                    ShowID = 0051,
                    Name = "The Sopranos",
                    Network = "HBO",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = "(1999–2007)",
                    Summary = "An innovative look at the life of fictional Mafia Capo Tony Soprano, this serial is presented largely first person, but additional perspective is conveyed by the intimate conversations Tony has with his psychotherapist. We see Tony at work, at home, and in therapy. Moments of black comedy intersperse this aggressive, adult drama, with adult language, and extreme violence.",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 86,
                },
                new Show
                {
                    ShowID = 0052,
                    Name = "Southland",
                    Network = "Warner Bros",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = "(2009–2013)",
                    Summary = "Veteran Los Angeles cop John Cooper is assigned to train rookie Ben Sherman, who finds himself questioning whether he has the right stuff to be a police officer after witnessing Cooper's no-nonsense approach. Other members of the police team include Detective Lydia Adams, who is her mother's primary caregiver away from the office; her partner, Russell Clarke, an unhappily married father of three; Detective Daniel 'Sal' Salinger, who oversees gang detectives Nate Moretta and Sammy Bryant; and patrol officer Chickie Brown, a single mother who dreams of joining the SWAT team.",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 43,
                },
                new Show
                {
                    ShowID = 0053,
                    Name = "South Park",
                    Network = "Comedy Central",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Comedy",
                    RunYears = "(1997– )",
                    Summary = "The curious, adventure-seeking, fourth grade group of boys, Stan, Kyle, Cartman, and Kenny, all join in in buffoonish adventures that sometimes evolve nothing. Sometimes something that was simple at the start, turns out to get out of control. Everything is odd in the small mountain town, South Park, and the boys always find something to do with it.",
                    Status = "Airing",
                    Rating = "TV-MA",
                    TotalEp = 281,
                    NextEpisode = new DateTime(2016,12,14,21,30,0),
                },
                new Show
                {
                    ShowID = 0054,
                    Name = "Stargate SG-1",
                    Network = "Syfy",
                    PrimaryGenre = "Adventure",
                    SencondaryGenre = "Sci-fi",
                    RunYears = "(1997–2007)",
                    Summary = "General Hammond summons Colonel Jack O'Neill out of retirement to embark on a secret rescue mission. O'Neill confesses that he disobeyed orders to destroy the Stargate on Planet Abydos, and that scientist Daniel Jackson may still be alive. Arriving on Abydos with his team, O'Neill meets up once again with the scientist, who has discovered a giant elaborate cartouche in hieroglyphics. All signs point to the fact that this is a map of many Stargates that exist throughout the galaxy - a development that makes the dream of the SG-1 team to travel throughout the universe in time a reality. ",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 213,
                },
                new Show
                {
                    ShowID = 0055,
                    Name = "Star Trek T.O.S.",
                    Network = "Paramount",
                    PrimaryGenre = "Sci-fi",
                    SencondaryGenre = "Adventure",
                    RunYears = "(1966–1969)",
                    Summary = "The adventures of the USS Enterprise, representing the United Federation of Planets on a five-year mission in outer space to explore new worlds, seek new life and new civilizations, and to boldly go where no one has gone before. The Enterprise is commanded by handsome and brash Captain James T. Kirk. His First Officer and best friend is Mr. Spock from the planet Vulcan, and Kirk's Medical Officer is Dr. Leonard 'Bones' McCoy. With a crew of approximately 430, the Enterprise battles aliens, megalomanical computers, time paradoxes, psychotic murderers, and even Khan!",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 80,
                },
                new Show
                {
                    ShowID = 0056,
                    Name = "Star Trek: The Next Generation",
                    Network = "Paramount",
                    PrimaryGenre = "Sci-fi",
                    SencondaryGenre = "Adventure",
                    RunYears = "(1987–1994)",
                    Summary = "Set in the 24th century and decades after the adventures of the original crew of the starship Enterprise, this new series is the long-awaited successor to the original Star Trek (1966). Under the command of Captain Jean-Luc Picard, the all new Enterprise NCC 1701-D travels out to distant planets to seek out new life and to boldly go where no one has gone before.",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 176,
                },
                new Show
                {
                    ShowID = 0057,
                    Name = "Steins;Gate",
                    Network = "Kadokawa",
                    PrimaryGenre = "Animation",
                    SencondaryGenre = "Sci-fi",
                    RunYears = "(2011–2012)",
                    Summary = "Okabe Rintarou, a university student who refers to himself as Crazy Mad Scientist Hououin Kyouma and his lab's members work on a microwave device that can transfer messages to the past. Without getting captured, they should get it working in order to beat the evil organization, SERN and stop their evil plans.",
                    Status = "Complete",
                    Rating = "TV-14 ",
                    TotalEp = 26,
                },
                new Show
                {
                    ShowID = 0058,
                    Name = "Stranger Things",
                    Network = "Netflix",
                    PrimaryGenre = "Sci-fi",
                    SencondaryGenre = "Mystery",
                    RunYears = "(2016– )",
                    Summary = "In a small town where everyone knows everyone, a peculiar incident starts a chain of events that leads to the disappearance of a child - which begins to tear at the fabric of an otherwise peaceful community. Dark government agencies and seemingly malevolent supernatural forces converge on the town, while a few locals begin to understand that there's more going on than meets the eye.",
                    Status = "Hiatus",
                    Rating = "TV-14 ",
                    TotalEp = 17,
                },
                new Show
                {
                    ShowID = 0059,
                    Name = "Suits",
                    Network = "Universal",
                    PrimaryGenre = "Comedy",
                    SencondaryGenre = "Drama",
                    RunYears = "(2011– )",
                    Summary = "While running from a drug deal gone bad, Mike Ross, a brilliant young college-dropout, slips into a job interview with one of New York City's best legal closers, Harvey Specter. Tired of cookie-cutter law school grads, Harvey takes a gamble by hiring Mike on the spot after he recognizes his raw talent and photographic memory. Mike and Harvey are a winning team. Even though Mike is a genius, he still has a lot to learn about law. And while Harvey may seem like an emotionless, cold-blooded shark, Mike's sympathy and concern for their cases and clients will help remind Harvey why he went into law in the first place. Mike's other allies in the office include the firm's best paralegal Rachel and Harvey's no-nonsense assistant Donna to help him serve justice.",
                    Status = "Hiatus",
                    Rating = "TV-14",
                    TotalEp = 94,
                },
                new Show
                {
                    ShowID = 0060,
                    Name = "Supernatural",
                    Network = "Warner Bros",
                    PrimaryGenre = "Drama",
                    SencondaryGenre = "Fantasy",
                    RunYears = "(2005– )",
                    Summary = "his television drama is about the two Winchester brothers, Sam and Dean, who were raised by their father, John, to hunt and kill all things that go 'bump in the night' after his wife, Mary, was murdered by an evil supernatural being when the boys were young. 22 years later the brothers set out on a journey, fighting evil along the way, to find their recently missing father who, when they finally meet up with, reveals he knows what killed their mother, a demon, and has found a way to track and kill it. Meanwhile, Sam starts to develop frightening abilities that include death visions, visions of people dying before it actually happens. These visions are somehow connected to the demon who murdered his mother and its mysterious plans that seem to be all about Sam. When their father dies striking a deal with the very same devil that had killed his wife, the brothers, now alone and without their mentor, are determined to finish the crusade their father started. ",
                    Status = "Airing",
                    Rating = "TV-14",
                    TotalEp = 265,
                    NextEpisode = new DateTime(2016,12,15,10,0,0),
                },
                new Show
                {
                    ShowID = 0061,
                    Name = "The Colbert Report",
                    Network = "Comedy Central",
                    PrimaryGenre = "Comedy",
                    SencondaryGenre = "Talk-show",
                    RunYears = "(2005–2015)",
                    Summary = "Satirical newscaster Stephen Colbert provides humorous commentary on the big issues going on in the United States and the rest of the world, with his larger-than-life ego and overly-patriotic spirit along with him every step of the way.",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 1389,
                },
                new Show
                {
                    ShowID = 0062,
                    Name = "The Inbetweeners",
                    Network = "MTV",
                    PrimaryGenre = "Comedy",
                    RunYears = "(2008–2010)",
                    Summary = "The exploits of four friends, who are socially only marginally above what one of them calls 'the freaks', are presented as they grow from their late teen years into adults and as they go on their quest, usually unsuccessfully, for such grown up things as beer and sex. Simon Cooper, Jay Cartwright and Neil Sutherland have been friends for some time. Insecure Simon's main quest in life is to get long time friend, Carli D'Amato, to be his girlfriend. Jay is the big talker whose stories, especially about his sexual conquests, are more fantasy than reality. And slightly dim-witted Neil is generally two steps behind everyone else in comprehension of life, and who is always defending his father from beliefs that he's a closet homosexual. Into the group comes its fourth member, Will McKenzie, who met them when he transferred into their school, Rudge Park Comprehensive, at the start of sixth form, as Will's newly divorced mum could no longer afford his private school tuition.",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 18,
                },
                new Show
                {
                    ShowID = 0063,
                    Name = "The IT Crowd",
                    Network = "Channel 4",
                    PrimaryGenre = "Comedy",
                    RunYears = "(2006–2013)",
                    Summary = "Deep in the sub basement of the ambiguous company of Reynholm Industries, are not one, but two socially awkward IT guys. Moss, an electronics wizard and overly naive man and Roy, a lazy disgruntled co-worker have to provide support for Reynholm Industries with their inept boss, Jen, who doesn't know the difference between hardware and software. The show revolves around Moss and Roy's antics both at work and out socially, which always ends badly",
                    Status = "Complete",
                    Rating = "TV-14",
                    TotalEp = 25,
                },
                new Show
                {
                    ShowID = 0064,
                    Name = "The Newsroom",
                    Network = "HBO",
                    PrimaryGenre = "Drama",
                    RunYears = "(2012–2014)",
                    Summary = "A news team attempts to create a news show that reports the news in an ethical and reasonable way. They take real, newsworthy events from our world as they're happening (such as bin Laden's assassination, NSA spying, etc) and report on them as if they were an actual news station that followed rational and moral guidelines, in a biting criticism of our popular press and a clever blurring of art and reality. ",
                    Status = "Complete",
                    Rating = "TV-MA ",
                    TotalEp = 25,
                },
                new Show
                {
                    ShowID = 0065,
                    Name = "The Office",
                    Network = "NBC",
                    PrimaryGenre = "Comedy",
                    RunYears = "(2005–2013)",
                    Summary = "A mediocre paper company in the hands of Scranton, PA branch manager Michael Scott. This mockumentary follows the everyday lives of the manager and the employees he 'manages.' The crew follows the employees around 24/7 and captures their quite humerous and bizarre encounters as they will do what it takes to keep the company thriving.",
                    Status = "Complete",
                    Rating = "TV-PG",
                    TotalEp = 188,
                },
                new Show
                {
                    ShowID = 0066,
                    Name = "The Shield",
                    Network = "FX",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = "(2002–2008)",
                    Summary = "The story of an inner-city Los Angeles police precinct where some of the cops aren't above breaking the rules or working against their associates to both keep the streets safe and their self-interests intact. ",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 89,
                },
                new Show
                {
                    ShowID = 0067,
                    Name = "The Wire",
                    Network = "HBO",
                    PrimaryGenre = "Crime",
                    SencondaryGenre = "Drama",
                    RunYears = "(2002–2008)",
                    Summary = "Set in Baltimore, this show centers around the city's inner-city drug scene. It starts as mid-level drug dealer, D'Angelo Barksdale beats a murder rap. After a conversation with a judge, Det. James McNulty has been assigned to lead a joint homicide and narcotics team, in order to bring down drug kingpin Avon Barksdale. Avon Barksdale, accompanied by his right-hand man Stringer Bell, enforcer Wee-Bey and many lieutenants (including his own nephew, D'Angelo Barksdale), has to deal with law enforcement, informants in his own camp, and competition with a local rival, Omar, who's been robbing Barksdale's dealers and reselling the drugs. The supervisor of the investigation, Lt. Cedric Daniels, has to deal with his own problems, such as a corrupt bureaucracy, some of his detectives beating suspects, hard-headed but determined Det. McNulty, and a blackmailing deputy. The show depicts the lives of every part of the drug 'food chain', from junkies to dealers, and from cops to politicians.",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 60,
                },
                new Show
                {
                    ShowID = 0068,
                    Name = "The X-Files",
                    Network = "20th Century Fox",
                    PrimaryGenre = "Mystery",
                    SencondaryGenre = "Sci-fi",
                    RunYears = "(1993– )",
                    Summary = "Two FBI agents, Fox Mulder and Dana Scully work in an unassigned detail of the bureau called the X-Files investigating cases dealing with unexplained paranormal phenomena. Mulder, a true believer, and Scully, a skeptic, perceive their cases from stand points of science and the paranormal.",
                    Status = "Hiatus",
                    Rating = "TV-14",
                    TotalEp = 203,
                },
                new Show
                {
                    ShowID = 0069,
                    Name = "Through the Wormhole",
                    Network = "Discovery",
                    PrimaryGenre = "Documentary",
                    RunYears = "(2010– )",
                    Summary = "Hosted by Morgan Freeman, Through the Wormhole will explore the deepest mysteries of existence - the questions that have puzzled mankind for eternity. What are we made of? What was there before the beginning? Are we really alone? Is there a creator? These questions have been pondered by the most exquisite minds of the human race. Now, science has evolved to the point where hard facts and evidence may be able to provide us with answers instead of philosophical theories. Through the Wormhole will bring together the brightest minds and best ideas from the very edges of science - Astrophysics, Astrobiology, Quantum Mechanics, String Theory, and more - to reveal the extraordinary truth of our Universe.",
                    Status = "Hiatus",
                    Rating = "TV-PG",
                    TotalEp = 60,
                },
                new Show
                {
                    ShowID = 0070,
                    Name = "Top Gear",
                    Network = "BBC",
                    PrimaryGenre = "Comedy",
                    SencondaryGenre = "Talk-show",
                    RunYears = "(2002– )",
                    Summary = "Top Gear is a British television series about motor vehicles, primarily cars, and is a relaunched version of the original 1977 show of the same name, airing since 2002, and becoming the most widely watched factual television programme in the world.",
                    Status = "Hiatus",
                    Rating = "TV-PG",
                    TotalEp = 243,
                },
                new Show
                {
                    ShowID = 0071,
                    Name = "True Detective",
                    Network = "HBO",
                    PrimaryGenre = "Drama",
                    SencondaryGenre = "Mystery",
                    RunYears = "(2014–2015)",
                    Summary = "In 2012, Louisiana State Police Detectives Rust Cohle and Martin Hart are brought in to revisit a homicide case they worked in 1995. As the inquiry unfolds in present day through separate interrogations, the two former detectives narrate the story of their investigation, reopening unhealed wounds, and drawing into question their supposed solving of a bizarre ritualistic murder in 1995. The timelines braid and converge in 2012 as each man is pulled back into a world they believed they'd left behind. In learning about each other and their killer, it becomes clear that darkness lives on both sides of the law.",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 16,
                },
                new Show
                {
                    ShowID = 0072,
                    Name = "Utopia",
                    Network = "Channel 4",
                    PrimaryGenre = "Drama",
                    SencondaryGenre = "Sci-fi",
                    RunYears = "(2013–2014)",
                    Summary = "Utopia will follow a group of people who find themselves in possession of a manuscript of a cult graphic novel. The tome is rumoured to have predicted the worst disasters of the last century and the group soon find themselves targeted by a shadowy organisation known only as The Network. ",
                    Status = "Complete",
                    Rating = "TV-MA",
                    TotalEp = 12,
                },
                new Show
                {
                    ShowID = 0073,
                    Name = "Vikings",
                    Network = "History Channel",
                    PrimaryGenre = "Action",
                    SencondaryGenre = "Drama",
                    RunYears = "(2013– )",
                    Summary = "The adventures of Ragnar Lothbrok: the greatest hero of his age. The series tells the saga of Ragnar's band of Viking brothers and his family as he rises to become King of the Viking tribes. As well as being a fearless warrior, Ragnar embodies the Norse traditions of devotion to the gods: legend has it that he was a direct descendant of Odin, the god of war and warriors.",
                    Status = "Airing",
                    Rating = "TV-14",
                    TotalEp = 53,
                },
                new Show
                {
                    ShowID = 0074,
                    Name = "The Walking Dead",
                    Network = "ABC",
                    PrimaryGenre = "Drama",
                    SencondaryGenre = "Thriller",
                    RunYears = "(2010– )",
                    Summary = "Rick Grimes is a former Sheriff's deputy who has been in a coma for several months after being shot while on duty. When he awakens he discovers that the world has been ravished by a zombie epidemic of apocalyptic proportions, and that he seems to be the only person still alive. After returning home to discover his wife and son missing, he runs into survivors Morgan and his son; who teach him the ropes of the new world. He then heads for Atlanta to search for his family. Narrowly escaping death at the hands of the zombies on arrival in Atlanta he is aided by another survivor, Glenn, who takes Rick to a camp outside the town. There Rick finds his wife Lori and his son, Carl, along with his partner/best friend Shane and a small group of survivors who struggle to fend off the zombie hordes; as well as competing with other surviving groups who are prepared to do whatever it takes to survive in this harsh new world. ",
                    Status = "Hiatus",
                    Rating = "TV-MA",
                    TotalEp = 105,
                },
                new Show
                {
                    ShowID = 0075,
                    Name = "Whose Line is it Anyway",
                    Network = "Warner Bros",
                    PrimaryGenre = "Comedy",
                    RunYears = "(2013– )",
                    Summary = "Aisha Tyler hosts this skit comedy show where the actors on the show, usually Wayne Brady, Colin Mochrie, Ryan Stiles and another guest star or two do different comedy skits. It's all improv and made up on the spot.",
                    Status = "Airing",
                    Rating = "TV-PG",
                    TotalEp = 77,
                } );
            #endregion
            #region Seasons
            context.Seasons.AddOrUpdate(
                s => new { s.ShowID, s.SeasonID },
            #region Show1: 24
                new Season
                {
                    ShowID = 0001,
                    SeasonID = 1,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0001,
                    SeasonID = 2,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0001,
                    SeasonID = 3,
                    SeasonYear = 2003,
                },
                new Season
                {
                    ShowID = 0001,
                    SeasonID = 4,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0001,
                    SeasonID = 5,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0001,
                    SeasonID = 6,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0001,
                    SeasonID = 7,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0001,
                    SeasonID = 8,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0001,
                    SeasonID = 9,
                    SeasonYear = 2014,
                },
            #endregion
            #region Show2: Archer
                new Season
                {
                    ShowID = 0002,
                    SeasonID = 1,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0002,
                    SeasonID = 2,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0002,
                    SeasonID = 3,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0002,
                    SeasonID = 4,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0002,
                    SeasonID = 5,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0002,
                    SeasonID = 6,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0002,
                    SeasonID = 7,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show3: Arrested Development
                new Season
                {
                    ShowID = 0003,
                    SeasonID = 1,
                    SeasonYear = 2003,
                },
                new Season
                {
                    ShowID = 0003,
                    SeasonID = 2,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0003,
                    SeasonID = 3,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0003,
                    SeasonID = 4,
                    SeasonYear = 2013,
                },
            #endregion
            #region Show4: Avatar
                new Season
                {
                    ShowID = 0004,
                    SeasonID = 1,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0004,
                    SeasonID = 2,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0004,
                    SeasonID = 3,
                    SeasonYear = 2007,
                },
            #endregion
            #region Show5: Band Of Brothers
                new Season
                {
                    ShowID = 0005,
                    SeasonID = 1,
                    SeasonYear = 2001,
                },
            #endregion
            #region Show6: Banshee
                new Season
                {
                    ShowID = 0006,
                    SeasonID = 1,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0006,
                    SeasonID = 2,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0006,
                    SeasonID = 3,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0006,
                    SeasonID = 4,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show7: Battlestar Galactica
                new Season
                {
                    ShowID = 0007,
                    SeasonID = 1,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0007,
                    SeasonID = 2,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0007,
                    SeasonID = 3,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0007,
                    SeasonID = 4,
                    SeasonYear = 2008,
                },
            #endregion
            #region Show8: Better Call Saul
                new Season
                {
                    ShowID = 0008,
                    SeasonID = 1,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0008,
                    SeasonID = 2,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show9: Black Mirror
                new Season
                {
                    ShowID = 0009,
                    SeasonID = 1,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0009,
                    SeasonID = 2,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0009,
                    SeasonID = 3,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show10: Breaking Bad
                new Season
                {
                    ShowID = 0010,
                    SeasonID = 1,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0010,
                    SeasonID = 2,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0010,
                    SeasonID = 3,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0010,
                    SeasonID = 4,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0010,
                    SeasonID = 5,
                    SeasonYear = 2012,
                },
            #endregion
            #region Show11: Broadchurch
                new Season
                {
                    ShowID = 0011,
                    SeasonID = 1,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0011,
                    SeasonID = 2,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show12: Community
                new Season
                {
                    ShowID = 0012,
                    SeasonID = 1,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0012,
                    SeasonID = 2,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0012,
                    SeasonID = 3,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0012,
                    SeasonID = 4,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0012,
                    SeasonID = 5,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0012,
                    SeasonID = 6,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show13: Cosmos
                new Season
                {
                    ShowID = 0013,
                    SeasonID = 1,
                    SeasonYear = 2014,
                },
            #endregion
            #region Show14: Daredevil
                new Season
                {
                    ShowID = 0014,
                    SeasonID = 1,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0014,
                    SeasonID = 2,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show15: Dexter
                new Season
                {
                    ShowID = 0015,
                    SeasonID = 1,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0015,
                    SeasonID = 2,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0015,
                    SeasonID = 3,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0015,
                    SeasonID = 4,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0015,
                    SeasonID = 5,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0015,
                    SeasonID = 6,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0015,
                    SeasonID = 7,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0015,
                    SeasonID = 8,
                    SeasonYear = 2013,
                },
            #endregion
            #region Show16: Doctor who
                new Season
                {
                    ShowID = 0016,
                    SeasonID = 1,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0016,
                    SeasonID = 2,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0016,
                    SeasonID = 3,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0016,
                    SeasonID = 4,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0016,
                    SeasonID = 5,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0016,
                    SeasonID = 6,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0016,
                    SeasonID = 7,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0016,
                    SeasonID = 8,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0016,
                    SeasonID = 9,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show17: Downton Abbey
                new Season
                {
                    ShowID = 0017,
                    SeasonID = 1,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0017,
                    SeasonID = 2,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0017,
                    SeasonID = 3,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0017,
                    SeasonID = 4,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0017,
                    SeasonID = 5,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0017,
                    SeasonID = 6,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show18: Dragon Ball Z
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 1,
                    SeasonYear = 1996,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 2,
                    SeasonYear = 1997,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 3,
                    SeasonYear = 1999,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 4,
                    SeasonYear = 1999,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 5,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 6,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 7,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 8,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 9,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 10,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 11,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 12,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 13,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 14,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 15,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0018,
                    SeasonID = 16,
                    SeasonYear = 2002,
                },
            #endregion
            #region Show19: Firefly
                new Season
                {
                    ShowID = 0019,
                    SeasonID = 1,
                    SeasonYear = 2002,
                },
            #endregion
            #region Show20: Friends
                new Season
                {
                    ShowID = 0020,
                    SeasonID = 1,
                    SeasonYear = 1994,
                },
                new Season
                {
                    ShowID = 0020,
                    SeasonID = 2,
                    SeasonYear = 1995,
                },
                new Season
                {
                    ShowID = 0020,
                    SeasonID = 3,
                    SeasonYear = 1996,
                },
                new Season
                {
                    ShowID = 0020,
                    SeasonID = 4,
                    SeasonYear = 1997,
                },
                new Season
                {
                    ShowID = 0020,
                    SeasonID = 5,
                    SeasonYear = 1998,
                },
                new Season
                {
                    ShowID = 0020,
                    SeasonID = 6,
                    SeasonYear = 1999,
                },
                new Season
                {
                    ShowID = 0020,
                    SeasonID = 7,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0020,
                    SeasonID = 8,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0020,
                    SeasonID = 9,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0020,
                    SeasonID = 10,
                    SeasonYear = 2003,
                },
            #endregion
            #region Show21: Fringe
                new Season
                {
                    ShowID = 0021,
                    SeasonID = 1,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0021,
                    SeasonID = 2,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0021,
                    SeasonID = 3,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0021,
                    SeasonID = 4,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0021,
                    SeasonID = 5,
                    SeasonYear = 2012,
                },
            #endregion
            #region Show22: Frozen Planet
                new Season
                {
                    ShowID = 0022,
                    SeasonID = 1,
                    SeasonYear = 2011,
                },
            #endregion
            #region Show23: Fullmetal Alchemist
                new Season
                {
                    ShowID = 0023,
                    SeasonID = 1,
                    SeasonYear = 2003,
                },
            #endregion
            #region Show24: Futurama
                new Season
                {
                    ShowID = 0024,
                    SeasonID = 1,
                    SeasonYear = 1999,
                },
                new Season
                {
                    ShowID = 0024,
                    SeasonID = 2,
                    SeasonYear = 1999,
                },
                new Season
                {
                    ShowID = 0024,
                    SeasonID = 3,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0024,
                    SeasonID = 4,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0024,
                    SeasonID = 5,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0024,
                    SeasonID = 6,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0024,
                    SeasonID = 7,
                    SeasonYear = 2012,
                },
            #endregion
            #region Show25: Game of Thrones
                new Season
                {
                    ShowID = 0025,
                    SeasonID = 1,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0025,
                    SeasonID = 2,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0025,
                    SeasonID = 3,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0025,
                    SeasonID = 4,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0025,
                    SeasonID = 5,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0025,
                    SeasonID = 6,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show26: Hannibal
                new Season
                {
                    ShowID = 0026,
                    SeasonID = 1,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0026,
                    SeasonID = 2,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0026,
                    SeasonID = 3,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show27: Homeland
                new Season
                {
                    ShowID = 0027,
                    SeasonID = 1,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0027,
                    SeasonID = 2,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0027,
                    SeasonID = 3,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0027,
                    SeasonID = 4,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0027,
                    SeasonID = 5,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show28: House
                new Season
                {
                    ShowID = 0028,
                    SeasonID = 1,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0028,
                    SeasonID = 2,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0028,
                    SeasonID = 3,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0028,
                    SeasonID = 4,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0028,
                    SeasonID = 5,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0028,
                    SeasonID = 6,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0028,
                    SeasonID = 7,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0028,
                    SeasonID = 8,
                    SeasonYear = 2010,
                },
            #endregion
            #region Show29: House of Cards
                new Season
                {
                    ShowID = 0029,
                    SeasonID = 1,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0029,
                    SeasonID = 2,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0029,
                    SeasonID = 3,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0029,
                    SeasonID = 4,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show30: Hunter x Hunter
                new Season
                {
                    ShowID = 0030,
                    SeasonID = 1,
                    SeasonYear = 2011,
                },
            #endregion
            #region Show31: John Oliver
                new Season
                {
                    ShowID = 0031,
                    SeasonID = 1,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0031,
                    SeasonID = 2,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0031,
                    SeasonID = 3,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show32: Legend of Korra
                new Season
                {
                    ShowID = 0032,
                    SeasonID = 1,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0032,
                    SeasonID = 2,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0032,
                    SeasonID = 3,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0032,
                    SeasonID = 4,
                    SeasonYear = 2014,
                },
            #endregion
            #region Show33: Lost
                new Season
                {
                    ShowID = 0033,
                    SeasonID = 1,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0033,
                    SeasonID = 2,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0033,
                    SeasonID = 3,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0033,
                    SeasonID = 4,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0033,
                    SeasonID = 5,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0033,
                    SeasonID = 6,
                    SeasonYear = 2010,
                },
            #endregion
            #region Show34: Making a murderer
                new Season
                {
                    ShowID = 0034,
                    SeasonID = 1,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show35: Modern Family
                new Season
                {
                    ShowID = 0035,
                    SeasonID = 1,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0035,
                    SeasonID = 2,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0035,
                    SeasonID = 3,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0035,
                    SeasonID = 4,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0035,
                    SeasonID = 5,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0035,
                    SeasonID = 6,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0035,
                    SeasonID = 7,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0035,
                    SeasonID = 8,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show36: Mr. Robot
                new Season
                {
                    ShowID = 0036,
                    SeasonID = 1,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0036,
                    SeasonID = 2,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show37: One punch man
                new Season
                {
                    ShowID = 0037,
                    SeasonID = 1,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show38: Parks and Recreation
                new Season
                {
                    ShowID = 0038,
                    SeasonID = 1,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0038,
                    SeasonID = 2,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0038,
                    SeasonID = 3,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0038,
                    SeasonID = 4,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0038,
                    SeasonID = 5,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0038,
                    SeasonID = 6,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0038,
                    SeasonID = 7,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show39: Person of Interest
                new Season
                {
                    ShowID = 0039,
                    SeasonID = 1,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0039,
                    SeasonID = 2,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0039,
                    SeasonID = 3,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0039,
                    SeasonID = 4,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0039,
                    SeasonID = 5,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show40: Planet Earth
                new Season
                {
                    ShowID = 0040,
                    SeasonID = 1,
                    SeasonYear = 2006,
                },
            #endregion
            #region Show41: Pride and Prejudice
                new Season
                {
                    ShowID = 0041,
                    SeasonID = 1,
                    SeasonYear = 1995,
                },
            #endregion
            #region Show42: Prison Break
                new Season
                {
                    ShowID = 0042,
                    SeasonID = 1,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0042,
                    SeasonID = 2,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0042,
                    SeasonID = 3,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0042,
                    SeasonID = 4,
                    SeasonYear = 2008,
                },
            #endregion
            #region Show43: Rick and Morty
                new Season
                {
                    ShowID = 0043,
                    SeasonID = 1,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0043,
                    SeasonID = 2,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show44: Scrubs
                new Season
                {
                    ShowID = 0044,
                    SeasonID = 1,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0044,
                    SeasonID = 2,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0044,
                    SeasonID = 3,
                    SeasonYear = 2003,
                },
                new Season
                {
                    ShowID = 0044,
                    SeasonID = 4,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0044,
                    SeasonID = 5,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0044,
                    SeasonID = 6,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0044,
                    SeasonID = 7,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0044,
                    SeasonID = 8,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0044,
                    SeasonID = 9,
                    SeasonYear = 2009,
                },
            #endregion
            #region Show45: Seinfeld
                new Season
                {
                    ShowID = 0045,
                    SeasonID = 1,
                    SeasonYear = 1989,
                },
                new Season
                {
                    ShowID = 0045,
                    SeasonID = 2,
                    SeasonYear = 1991,
                },
                new Season
                {
                    ShowID = 0045,
                    SeasonID = 3,
                    SeasonYear = 1991,
                },
                new Season
                {
                    ShowID = 0045,
                    SeasonID = 4,
                    SeasonYear = 1992,
                },
                new Season
                {
                    ShowID = 0045,
                    SeasonID = 5,
                    SeasonYear = 1993,
                },
                new Season
                {
                    ShowID = 0045,
                    SeasonID = 6,
                    SeasonYear = 1994,
                },
                new Season
                {
                    ShowID = 0045,
                    SeasonID = 7,
                    SeasonYear = 1995,
                },
                new Season
                {
                    ShowID = 0045,
                    SeasonID = 8,
                    SeasonYear = 1996,
                },
                new Season
                {
                    ShowID = 0045,
                    SeasonID = 9,
                    SeasonYear = 1997,
                },
            #endregion
            #region Show46: Sherlock
                new Season
                {
                    ShowID = 0046,
                    SeasonID = 1,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0046,
                    SeasonID = 2,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0046,
                    SeasonID = 3,
                    SeasonYear = 2014,
                },
            #endregion
            #region Show47: Silicon Valley
                new Season
                {
                    ShowID = 0047,
                    SeasonID = 1,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0047,
                    SeasonID = 2,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0047,
                    SeasonID = 3,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show48: Simpsons
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 1,
                    SeasonYear = 1989,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 2,
                    SeasonYear = 1990,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 3,
                    SeasonYear = 1991,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 4,
                    SeasonYear = 1992,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 5,
                    SeasonYear = 1993,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 6,
                    SeasonYear = 1994,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 7,
                    SeasonYear = 1995,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 8,
                    SeasonYear = 1996,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 9,
                    SeasonYear = 1997,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 10,
                    SeasonYear = 1998,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 11,
                    SeasonYear = 1999,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 12,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 13,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 14,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 15,
                    SeasonYear = 2003,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 16,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 17,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 18,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 19,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 20,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 21,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 22,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 23,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 24,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 25,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 26,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 27,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0048,
                    SeasonID = 28,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show49: Six feet under
                new Season
                {
                    ShowID = 0049,
                    SeasonID = 1,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0049,
                    SeasonID = 2,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0049,
                    SeasonID = 3,
                    SeasonYear = 2003,
                }, 
                new Season
                {
                    ShowID = 0049,
                    SeasonID = 4,
                    SeasonYear = 2004,
                },
                new Season
                {   
                    ShowID = 0049,
                    SeasonID = 5,
                    SeasonYear = 2005,
                },
            #endregion
            #region Show50: Sons of anarchy
                new Season
                {
                    ShowID = 0050,
                    SeasonID = 1,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0050,
                    SeasonID = 2,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0050,
                    SeasonID = 3,
                    SeasonYear = 2010,
                }, 
                new Season
                {
                    ShowID = 0050,
                    SeasonID = 4,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0050,
                    SeasonID = 5,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0050,
                    SeasonID = 6,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0050,
                    SeasonID = 7,
                    SeasonYear = 2014,
                },
            #endregion
            #region Show51: The Sopranos
                new Season
                {
                    ShowID = 0051,
                    SeasonID = 1,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0051,
                    SeasonID = 2,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0051,
                    SeasonID = 3,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0051,
                    SeasonID = 4,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0051,
                    SeasonID = 5,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0051,
                    SeasonID = 6,
                    SeasonYear = 2013,
                },
            #endregion
            #region Show52: Southland
                new Season
                {
                    ShowID = 0052,
                    SeasonID = 1,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0052,
                    SeasonID = 2,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0052,
                    SeasonID = 3,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0052,
                    SeasonID = 4,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0052,
                    SeasonID = 5,
                    SeasonYear = 2013,
                },
            #endregion
            #region Show53: South Park
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 1,
                    SeasonYear = 1997,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 2,
                    SeasonYear = 1998,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 3,
                    SeasonYear = 1999,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 4,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 5,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 6,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 7,
                    SeasonYear = 2003,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 8,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 9,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 10,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 11,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 12,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 13,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 14,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 15,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 16,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 17,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 18,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 19,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0053,
                    SeasonID = 20,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show54: SG-1
                new Season
                {
                    ShowID = 0054,
                    SeasonID = 1,
                    SeasonYear = 1997,
                },
                new Season
                {
                    ShowID = 0054,
                    SeasonID = 2,
                    SeasonYear = 1998,
                },
                new Season
                {
                    ShowID = 0054,
                    SeasonID = 3,
                    SeasonYear = 1999,
                },
                new Season
                {
                    ShowID = 0054,
                    SeasonID = 4,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0054,
                    SeasonID = 5,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0054,
                    SeasonID = 6,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0054,
                    SeasonID = 7,
                    SeasonYear = 2003,
                },
                new Season
                {
                    ShowID = 0054,
                    SeasonID = 8,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0054,
                    SeasonID = 9,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0054,
                    SeasonID = 10,
                    SeasonYear = 2006,
                },
            #endregion
            #region Show55: Star Trek TOS
                new Season
                {
                    ShowID = 0055,
                    SeasonID = 1,
                    SeasonYear = 1966,
                },
                new Season
                {
                    ShowID = 0055,
                    SeasonID = 2,
                    SeasonYear = 1967,
                },
                new Season
                {
                    ShowID = 0055,
                    SeasonID = 3,
                    SeasonYear = 1968,
                },
            #endregion
            #region Show56: Star Trek TNG
                new Season
                {
                    ShowID = 0056,
                    SeasonID = 1,
                    SeasonYear = 1987,
                },
                new Season
                {
                    ShowID = 0056,
                    SeasonID = 2,
                    SeasonYear = 1988,
                },
                new Season
                {
                    ShowID = 0056,
                    SeasonID = 3,
                    SeasonYear = 1989,
                },
                new Season
                {
                    ShowID = 0056,
                    SeasonID = 4,
                    SeasonYear = 1990,
                },
                new Season
                {
                    ShowID = 0056,
                    SeasonID = 5,
                    SeasonYear = 1991,
                },
                new Season
                {
                    ShowID = 0056,
                    SeasonID = 6,
                    SeasonYear = 1992,
                },
                new Season
                {
                    ShowID = 0056,
                    SeasonID = 7,
                    SeasonYear = 1993,
                },
            #endregion
            #region Show57: Steins Gate
                new Season
                {
                    ShowID = 0057,
                    SeasonID = 1,
                    SeasonYear = 2011,
                },
            #endregion
            #region Show58: Stranger Things
                new Season
                {
                    ShowID = 0058,
                    SeasonID = 1,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show59: Suits
                new Season
                {
                    ShowID = 0059,
                    SeasonID = 1,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0059,
                    SeasonID = 2,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0059,
                    SeasonID = 3,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0059,
                    SeasonID = 4,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0059,
                    SeasonID = 5,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0059,
                    SeasonID = 6,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show60: Supernatural
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 1,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 2,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 3,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 4,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 5,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 6,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 7,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 8,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 9,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 10,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 11,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0060,
                    SeasonID = 12,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show61: The Colbert Report
                new Season
                {
                    ShowID = 0061,
                    SeasonID = 1,
                    SeasonYear = 2005,
                },
            #endregion
            #region Show62: Suits
                new Season
                {
                    ShowID = 0062,
                    SeasonID = 1,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0062,
                    SeasonID = 2,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0062,
                    SeasonID = 3,
                    SeasonYear = 2010,
                },
            #endregion
            #region Show63: The IT Crowd
                new Season
                {
                    ShowID = 0063,
                    SeasonID = 1,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0063,
                    SeasonID = 2,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0063,
                    SeasonID = 3,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0063,
                    SeasonID = 4,
                    SeasonYear = 2010,
                },
            #endregion
            #region Show64: The Newsroom
                new Season
                {
                    ShowID = 0064,
                    SeasonID = 1,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0064,
                    SeasonID = 2,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0064,
                    SeasonID = 3,
                    SeasonYear = 2014,
                },
            #endregion
            #region Show65: The Office
                new Season
                {
                    ShowID = 0065,
                    SeasonID = 1,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0065,
                    SeasonID = 2,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0065,
                    SeasonID = 3,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0065,
                    SeasonID = 4,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0065,
                    SeasonID = 5,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0065,
                    SeasonID = 6,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0065,
                    SeasonID = 7,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0065,
                    SeasonID = 8,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0065,
                    SeasonID = 9,
                    SeasonYear = 2012,
                },
            #endregion
            #region Show66: The Shield
                new Season
                {
                    ShowID = 0066,
                    SeasonID = 1,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0066,
                    SeasonID = 2,
                    SeasonYear = 2003,
                },
                new Season
                {
                    ShowID = 0066,
                    SeasonID = 3,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0066,
                    SeasonID = 4,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0066,
                    SeasonID = 5,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0066,
                    SeasonID = 6,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0066,
                    SeasonID = 7,
                    SeasonYear = 2008,
                },
            #endregion
            #region Show67: The Wire
                new Season
                {
                    ShowID = 0067,
                    SeasonID = 1,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0067,
                    SeasonID = 2,
                    SeasonYear = 2003,
                },
                new Season
                {
                    ShowID = 0067,
                    SeasonID = 3,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0067,
                    SeasonID = 4,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0067,
                    SeasonID = 5,
                    SeasonYear = 2008,
                },
            #endregion
            #region Show68: The X Files
                new Season
                {
                    ShowID = 0068,
                    SeasonID = 1,
                    SeasonYear = 1993,
                },
                new Season
                {
                    ShowID = 0068,
                    SeasonID = 2,
                    SeasonYear = 1994,
                },
                new Season
                {
                    ShowID = 0068,
                    SeasonID = 3,
                    SeasonYear = 1995,
                },
                new Season
                {
                    ShowID = 0068,
                    SeasonID = 4,
                    SeasonYear = 1996,
                },
                new Season
                {
                    ShowID = 0068,
                    SeasonID = 5,
                    SeasonYear = 1997,
                },
                new Season
                {
                    ShowID = 0068,
                    SeasonID = 6,
                    SeasonYear = 1998,
                },
                new Season
                {
                    ShowID = 0068,
                    SeasonID = 7,
                    SeasonYear = 1999,
                },
                new Season
                {
                    ShowID = 0068,
                    SeasonID = 8,
                    SeasonYear = 2000,
                },
                new Season
                {
                    ShowID = 0068,
                    SeasonID = 9,
                    SeasonYear = 2001,
                },
                new Season
                {
                    ShowID = 0068,
                    SeasonID = 10,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show69: Through the Wormhole
                new Season
                {
                    ShowID = 0069,
                    SeasonID = 1,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0069,
                    SeasonID = 2,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0069,
                    SeasonID = 3,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0069,
                    SeasonID = 4,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0069,
                    SeasonID = 5,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0069,
                    SeasonID = 6,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0069,
                    SeasonID = 7,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show70: Top Gear
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 1,
                    SeasonYear = 2002,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 2,
                    SeasonYear = 2003,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 3,
                    SeasonYear = 2003,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 4,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 5,
                    SeasonYear = 2004,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 6,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 7,
                    SeasonYear = 2005,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 8,
                    SeasonYear = 2006,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 9,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 10,
                    SeasonYear = 2007,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 11,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 12,
                    SeasonYear = 2008,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 13,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 14,
                    SeasonYear = 2009,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 15,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 16,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 17,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 18,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 19,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 20,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 21,
                    SeasonYear = 2014,
                },

                new Season
                {
                    ShowID = 0070,
                    SeasonID = 22,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0070,
                    SeasonID = 23,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show71: True Detective
                new Season
                {
                    ShowID = 0071,
                    SeasonID = 1,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0071,
                    SeasonID = 2,
                    SeasonYear = 2015,
                },
            #endregion
            #region Show72: Through the Wormhole
                new Season
                {
                    ShowID = 0072,
                    SeasonID = 1,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0072,
                    SeasonID = 2,
                    SeasonYear = 2014,
                },
            #endregion
            #region Show73: Vikings
                new Season
                {
                    ShowID = 0073,
                    SeasonID = 1,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0073,
                    SeasonID = 2,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0073,
                    SeasonID = 3,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0073,
                    SeasonID = 4,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show74: The Walking Dead
                new Season
                {
                    ShowID = 0074,
                    SeasonID = 1,
                    SeasonYear = 2010,
                },
                new Season
                {
                    ShowID = 0074,
                    SeasonID = 2,
                    SeasonYear = 2011,
                },
                new Season
                {
                    ShowID = 0074,
                    SeasonID = 3,
                    SeasonYear = 2012,
                },
                new Season
                {
                    ShowID = 0074,
                    SeasonID = 4,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0074,
                    SeasonID = 5,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0074,
                    SeasonID = 6,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0074,
                    SeasonID = 7,
                    SeasonYear = 2016,
                },
            #endregion
            #region Show75: Whose Line is it anyways
                new Season
                {
                    ShowID = 0075,
                    SeasonID = 1,
                    SeasonYear = 2013,
                },
                new Season
                {
                    ShowID = 0075,
                    SeasonID = 2,
                    SeasonYear = 2014,
                },
                new Season
                {
                    ShowID = 0075,
                    SeasonID = 3,
                    SeasonYear = 2015,
                },
                new Season
                {
                    ShowID = 0075,
                    SeasonID = 4,
                    SeasonYear = 2016,
                }
            #endregion
        );
            #endregion
            #region Episodes
            context.Episodes.AddOrUpdate(
                e => new { e.ShowID, e.SeasonID, e.EpisodeID },
            #region Show1S1
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 1,
                    Title = "12:00 a.m. – 1:00 a.m.",
                    AirDate = DateTime.Parse("November 6, 2001")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 2,
                    Title = "1:00 a.m. – 2:00 a.m.",
                    AirDate = DateTime.Parse("November 13, 2001")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 3,
                    Title = "2:00 a.m. – 3:00 a.m.",
                    AirDate = DateTime.Parse("November 20, 2001")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 4,
                    Title = "3:00 a.m. – 4:00 a.m.",
                    AirDate = DateTime.Parse("November 27, 2001")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 5,
                    Title = "4:00 a.m. – 5:00 a.m.",
                    AirDate = DateTime.Parse("December 11, 2001")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 6,
                    Title = "5:00 a.m. – 6:00 a.m.",
                    AirDate = DateTime.Parse("December 18, 2001")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 7,
                    Title = "6:00 a.m. – 7:00 a.m.",
                    AirDate = DateTime.Parse("January 8, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 8,
                    Title = "7:00 a.m. – 8:00 a.m.",
                    AirDate = DateTime.Parse("January 15, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 9,
                    Title = "8:00 a.m. – 9:00 a.m.",
                    AirDate = DateTime.Parse("January 22, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 10,
                    Title = "9:00 a.m. – 10:00 a.m.",
                    AirDate = DateTime.Parse("February 5, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 11,
                    Title = "10:00 a.m. – 11:00 a.m.",
                    AirDate = DateTime.Parse("February 12, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 12,
                    Title = "11:00 a.m. – 12:00 p.m.",
                    AirDate = DateTime.Parse("February 19, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 13,
                    Title = "12:00 p.m. – 1:00 p.m.",
                    AirDate = DateTime.Parse("February 26, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 14,
                    Title = "1:00 p.m. – 2:00 p.m.",
                    AirDate = DateTime.Parse("March 5, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 15,
                    Title = "2:00 p.m. – 3:00 p.m.",
                    AirDate = DateTime.Parse("March 12, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 16,
                    Title = "3:00 p.m. – 4:00 p.m.",
                    AirDate = DateTime.Parse("March 19, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 17,
                    Title = "4:00 p.m. – 5:00 p.m.",
                    AirDate = DateTime.Parse("March 26, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 18,
                    Title = "5:00 p.m. – 6:00 p.m.",
                    AirDate = DateTime.Parse("April 2, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 19,
                    Title = "6:00 p.m. – 7:00 p.m.",
                    AirDate = DateTime.Parse("April 9, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 20,
                    Title = "7:00 p.m. – 8:00 p.m.",
                    AirDate = DateTime.Parse("April 16, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 21,
                    Title = "8:00 p.m. – 9:00 p.m.",
                    AirDate = DateTime.Parse("April 23, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 22,
                    Title = "9:00 p.m. – 10:00 p.m.",
                    AirDate = DateTime.Parse("May 7, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 23,
                    Title = "10:00 p.m. – 11:00 p.m.",
                    AirDate = DateTime.Parse("May 14, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 1,
                    EpisodeID = 24,
                    Title = "11:00 p.m. – 12:00 a.m.",
                    AirDate = DateTime.Parse("May 21, 2002")
                },
            #endregion
            #region Show1S2
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 1,
                    Title = "Day 2: 8:00 a.m. – 9:00 a.m.",
                    AirDate = DateTime.Parse("October 29, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 2,
                    Title = "Day 2: 9:00 a.m. – 10:00 a.m.",
                    AirDate = DateTime.Parse("November 5, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 3,
                    Title = "Day 2: 10:00 a.m. – 11:00 a.m.",
                    AirDate = DateTime.Parse("November 12, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 4,
                    Title = "Day 2: 11:00 a.m. – 12:00 p.m.",
                    AirDate = DateTime.Parse("November 19, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 5,
                    Title = "Day 2: 12:00 p.m. – 1:00 p.m.",
                    AirDate = DateTime.Parse("November 26, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 6,
                    Title = "Day 2: 1:00 p.m. – 2:00 p.m.",
                    AirDate = DateTime.Parse("December 3, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 7,
                    Title = "Day 2: 2:00 p.m. – 3:00 p.m.",
                    AirDate = DateTime.Parse("December 10, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 8,
                    Title = "Day 2: 3:00 p.m. – 4:00 p.m.",
                    AirDate = DateTime.Parse("December 17, 2002")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 9,
                    Title = "Day 2: 4:00 p.m. – 5:00 p.m.",
                    AirDate = DateTime.Parse("January 7, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 10,
                    Title = "Day 2: 5:00 p.m. – 6:00 p.m.",
                    AirDate = DateTime.Parse("January 14, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 11,
                    Title = "Day 2: 6:00 p.m. – 7:00 p.m.",
                    AirDate = DateTime.Parse("February 4, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 12,
                    Title = "Day 2: 7:00 p.m. – 8:00 p.m.",
                    AirDate = DateTime.Parse("February 11, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 13,
                    Title = "Day 2: 8:00 p.m. – 9:00 p.m.",
                    AirDate = DateTime.Parse("February 18, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 14,
                    Title = "Day 2: 9:00 p.m. – 10:00 p.m.",
                    AirDate = DateTime.Parse("February 25, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 15,
                    Title = "Day 2: 10:00 p.m. – 11:00 p.m.",
                    AirDate = DateTime.Parse("March 4, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 16,
                    Title = "Day 2: 11:00 p.m. – 12:00 a.m.",
                    AirDate = DateTime.Parse("March 25, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 17,
                    Title = "Day 2: 12:00 a.m. – 1:00 a.m.",
                    AirDate = DateTime.Parse("April 1, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 18,
                    Title = "Day 2: 1:00 a.m. – 2:00 a.m.",
                    AirDate = DateTime.Parse("April 8, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 19,
                    Title = "Day 2: 2:00 a.m. – 3:00 a.m.",
                    AirDate = DateTime.Parse("April 15, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 20,
                    Title = "Day 2: 3:00 a.m. – 4:00 a.m.",
                    AirDate = DateTime.Parse("April 22, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 21,
                    Title = "Day 2: 4:00 a.m. – 5:00 a.m.",
                    AirDate = DateTime.Parse("April 29, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 22,
                    Title = "Day 2: 5:00 a.m. – 6:00 a.m.",
                    AirDate = DateTime.Parse("May 6, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 23,
                    Title = "Day 2: 6:00 a.m. – 7:00 a.m.",
                    AirDate = DateTime.Parse("May 13, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 2,
                    EpisodeID = 24,
                    Title = "Day 2: 7:00 a.m. – 8:00 a.m.",
                    AirDate = DateTime.Parse("May 20, 2003")
                },
            #endregion
            #region Show1S3
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 1,
                    Title = "Day 3: 1:00 p.m. – 2:00 p.m.",
                    AirDate = DateTime.Parse("October 28, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 2,
                    Title = "Day 3: 2:00 p.m. – 3:00 p.m.",
                    AirDate = DateTime.Parse("November 4, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 3,
                    Title = "Day 3: 3:00 p.m. – 4:00 p.m.",
                    AirDate = DateTime.Parse("November 11, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 4,
                    Title = "Day 3: 4:00 p.m. – 5:00 p.m.",
                    AirDate = DateTime.Parse("November 18, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 5,
                    Title = "Day 3: 5:00 p.m. – 6:00 p.m.",
                    AirDate = DateTime.Parse("November 25, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 6,
                    Title = "Day 3: 6:00 p.m. – 7:00 p.m.",
                    AirDate = DateTime.Parse("December 2, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 7,
                    Title = "Day 3: 7:00 p.m. – 8:00 p.m.",
                    AirDate = DateTime.Parse("December 9, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 8,
                    Title = "Day 3: 8:00 p.m. – 9:00 p.m.",
                    AirDate = DateTime.Parse("December 16, 2003")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 9,
                    Title = "Day 3: 9:00 p.m. – 10:00 p.m.",
                    AirDate = DateTime.Parse("January 6, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 10,
                    Title = "Day 3: 10:00 p.m. – 11:00 p.m.",
                    AirDate = DateTime.Parse("January 13, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 11,
                    Title = "Day 3: 11:00 p.m. – 12:00 a.m.",
                    AirDate = DateTime.Parse("January 27, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 12,
                    Title = "Day 3: 12:00 a.m. – 1:00 a.m.",
                    AirDate = DateTime.Parse("February 3, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 13,
                    Title = "Day 3: 1:00 a.m. – 2:00 a.m.",
                    AirDate = DateTime.Parse("February 10, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 14,
                    Title = "Day 3: 2:00 a.m. – 3:00 a.m.",
                    AirDate = DateTime.Parse("February 17, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 15,
                    Title = "Day 3: 3:00 a.m. – 4:00 a.m.",
                    AirDate = DateTime.Parse("February 24, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 16,
                    Title = "Day 3: 4:00 a.m. – 5:00 a.m.",
                    AirDate = DateTime.Parse("March 30, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 17,
                    Title = "Day 3: 5:00 a.m. – 6:00 a.m.",
                    AirDate = DateTime.Parse("April 6, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 18,
                    Title = "Day 3: 6:00 a.m. – 7:00 a.m.",
                    AirDate = DateTime.Parse("April 18, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 19,
                    Title = "Day 3: 7:00 a.m. – 8:00 a.m.",
                    AirDate = DateTime.Parse("April 20, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 20,
                    Title = "Day 3: 8:00 a.m. – 9:00 a.m.",
                    AirDate = DateTime.Parse("April 27, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 21,
                    Title = "Day 3: 9:00 a.m. – 10:00 a.m.",
                    AirDate = DateTime.Parse("May 4, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 22,
                    Title = "Day 3: 10:00 a.m. – 11:00 a.m.",
                    AirDate = DateTime.Parse("May 11, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 23,
                    Title = "Day 3: 11:00 a.m. – 12:00 p.m.",
                    AirDate = DateTime.Parse("May 18, 2004")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 3,
                    EpisodeID = 24,
                    Title = "Day 3: 12:00 p.m. – 1:00 p.m.",
                    AirDate = DateTime.Parse("May 25, 2004")
                },
            #endregion
            #region Show1S4
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 1,
                    Title = "Day 4: 7:00 a.m. – 8:00 a.m.",
                    AirDate = DateTime.Parse("January 9, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 2,
                    Title = "Day 4: 8:00 a.m. – 9:00 a.m.",
                    AirDate = DateTime.Parse("January 9, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 3,
                    Title = "Day 4: 9:00 a.m. – 10:00 a.m.",
                    AirDate = DateTime.Parse("January 10, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 4,
                    Title = "Day 4: 10:00 a.m. – 11:00 a.m.",
                    AirDate = DateTime.Parse("January 10, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 5,
                    Title = "Day 4: 11:00 a.m. – 12:00 p.m.",
                    AirDate = DateTime.Parse("January 17, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 6,
                    Title = "Day 4: 12:00 p.m. – 1:00 p.m.",
                    AirDate = DateTime.Parse("January 24, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 7,
                    Title = "Day 4: 1:00 p.m. – 2:00 p.m.",
                    AirDate = DateTime.Parse("January 31, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 8,
                    Title = "Day 4: 2:00 p.m. – 3:00 p.m.",
                    AirDate = DateTime.Parse("February 7, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 9,
                    Title = "Day 4: 3:00 p.m. – 4:00 p.m.",
                    AirDate = DateTime.Parse("February 14, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 10,
                    Title = "Day 4: 4:00 p.m. – 5:00 p.m.",
                    AirDate = DateTime.Parse("February 21, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 11,
                    Title = "Day 4: 5:00 p.m. – 6:00 p.m.",
                    AirDate = DateTime.Parse("February 28, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 12,
                    Title = "Day 4: 6:00 p.m. – 7:00 p.m.",
                    AirDate = DateTime.Parse("March 7, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 13,
                    Title = "Day 4: 7:00 p.m. – 8:00 p.m.",
                    AirDate = DateTime.Parse("March 14, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 14,
                    Title = "Day 4: 8:00 p.m. – 9:00 p.m.",
                    AirDate = DateTime.Parse("March 21, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 15,
                    Title = "Day 4: 9:00 p.m. – 10:00 p.m.",
                    AirDate = DateTime.Parse("March 28, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 16,
                    Title = "Day 4: 10:00 p.m. – 11:00 p.m.",
                    AirDate = DateTime.Parse("April 4, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 17,
                    Title = "Day 4: 11:00 p.m. – 12:00 a.m.",
                    AirDate = DateTime.Parse("April 11, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 18,
                    Title = "Day 4: 12:00 a.m. – 1:00 a.m.",
                    AirDate = DateTime.Parse("April 18, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 19,
                    Title = "Day 4: 1:00 a.m. – 2:00 a.m.",
                    AirDate = DateTime.Parse("April 25, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 20,
                    Title = "Day 4: 2:00 a.m. – 3:00 a.m.",
                    AirDate = DateTime.Parse("May 2, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 21,
                    Title = "Day 4: 3:00 a.m. – 4:00 a.m.",
                    AirDate = DateTime.Parse("May 9, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 22,
                    Title = "Day 4: 4:00 a.m. – 5:00 a.m.",
                    AirDate = DateTime.Parse("May 16, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 23,
                    Title = "Day 4: 5:00 a.m. – 6:00 a.m.",
                    AirDate = DateTime.Parse("May 23, 2005")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 4,
                    EpisodeID = 24,
                    Title = "Day 4: 6:00 a.m. – 7:00 a.m.",
                    AirDate = DateTime.Parse("May 23, 2005")
                },
            #endregion
            #region Show1S5
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 1,
                    Title = "Day 5: 7:00 a.m. – 8:00 a.m.",
                    AirDate = DateTime.Parse("January 15, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 2,
                    Title = "Day 5: 8:00 a.m. – 9:00 a.m.",
                    AirDate = DateTime.Parse("January 15, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 3,
                    Title = "Day 5: 9:00 a.m. – 10:00 a.m.",
                    AirDate = DateTime.Parse("January 16, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 4,
                    Title = "Day 5: 10:00 a.m. – 11:00 a.m.",
                    AirDate = DateTime.Parse("January 16, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 5,
                    Title = "Day 5: 11:00 a.m. – 12:00 p.m.",
                    AirDate = DateTime.Parse("January 23, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 6,
                    Title = "Day 5: 12:00 p.m. – 1:00 p.m.",
                    AirDate = DateTime.Parse("January 30, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 7,
                    Title = "Day 5: 1:00 p.m. – 2:00 p.m.",
                    AirDate = DateTime.Parse("February 6, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 8,
                    Title = "Day 5: 2:00 p.m. – 3:00 p.m.",
                    AirDate = DateTime.Parse("February 13, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 9,
                    Title = "Day 5: 3:00 p.m. – 4:00 p.m.",
                    AirDate = DateTime.Parse("February 20, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 10,
                    Title = "Day 5: 4:00 p.m. – 5:00 p.m.",
                    AirDate = DateTime.Parse("February 27, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 11,
                    Title = "Day 5: 5:00 p.m. – 6:00 p.m.",
                    AirDate = DateTime.Parse("March 6, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 12,
                    Title = "Day 5: 6:00 p.m. – 7:00 p.m.",
                    AirDate = DateTime.Parse("March 6, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 13,
                    Title = "Day 5: 7:00 p.m. – 8:00 p.m.",
                    AirDate = DateTime.Parse("March 13, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 14,
                    Title = "Day 5: 8:00 p.m. – 9:00 p.m.",
                    AirDate = DateTime.Parse("March 20, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 15,
                    Title = "Day 5: 9:00 p.m. – 10:00 p.m.",
                    AirDate = DateTime.Parse("March 27, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 16,
                    Title = "Day 5: 10:00 p.m. – 11:00 p.m.",
                    AirDate = DateTime.Parse("April 3, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 17,
                    Title = "Day 5: 11:00 p.m. – 12:00 a.m.",
                    AirDate = DateTime.Parse("April 10, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 18,
                    Title = "Day 5: 12:00 a.m. – 1:00 a.m.",
                    AirDate = DateTime.Parse("April 17, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 19,
                    Title = "Day 5: 1:00 a.m. – 2:00 a.m.",
                    AirDate = DateTime.Parse("April 24, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 20,
                    Title = "Day 5: 2:00 a.m. – 3:00 a.m.",
                    AirDate = DateTime.Parse("May 1, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 21,
                    Title = "Day 5: 3:00 a.m. – 4:00 a.m.",
                    AirDate = DateTime.Parse("May 8, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 22,
                    Title = "Day 5: 4:00 a.m. – 5:00 a.m.",
                    AirDate = DateTime.Parse("May 15, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 23,
                    Title = "Day 5: 5:00 a.m. – 6:00 a.m.",
                    AirDate = DateTime.Parse("May 22, 2006")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 5,
                    EpisodeID = 24,
                    Title = "Day 5: 6:00 a.m. – 7:00 a.m.",
                    AirDate = DateTime.Parse("May 22, 2006")
                },
                            #endregion
                #region Show1S6
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 1,
                    Title = "Day 6: 6:00 a.m. – 7:00 a.m.",
                    AirDate = DateTime.Parse("January 14, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 2,
                    Title = "Day 6: 7:00 a.m. – 8:00 a.m.",
                    AirDate = DateTime.Parse("January 14, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 3,
                    Title = "Day 6: 8:00 a.m. – 9:00 a.m.",
                    AirDate = DateTime.Parse("January 15, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 4,
                    Title = "Day 6: 9:00 a.m. – 10:00 a.m.",
                    AirDate = DateTime.Parse("January 15, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 5,
                    Title = "Day 6: 10:00 a.m. – 11:00 a.m.",
                    AirDate = DateTime.Parse("January 22, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 6,
                    Title = "Day 6: 11:00 a.m. – 12:00 p.m.",
                    AirDate = DateTime.Parse("January 29, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 7,
                    Title = "Day 6: 12:00 p.m. – 1:00 p.m.",
                    AirDate = DateTime.Parse("February 5, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 8,
                    Title = "Day 6: 1:00 p.m. – 2:00 p.m.",
                    AirDate = DateTime.Parse("February 12, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 9,
                    Title = "Day 6: 2:00 p.m. – 3:00 p.m.",
                    AirDate = DateTime.Parse("February 12, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 10,
                    Title = "Day 6: 3:00 p.m. – 4:00 p.m.",
                    AirDate = DateTime.Parse("February 19, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 11,
                    Title = "Day 6: 4:00 p.m. – 5:00 p.m.",
                    AirDate = DateTime.Parse("February 26, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 12,
                    Title = "Day 6: 5:00 p.m. – 6:00 p.m.",
                    AirDate = DateTime.Parse("March 5, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 13,
                    Title = "Day 6: 6:00 p.m. – 7:00 p.m.",
                    AirDate = DateTime.Parse("March 12, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 14,
                    Title = "Day 6: 7:00 p.m. – 8:00 p.m.",
                    AirDate = DateTime.Parse("March 19, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 15,
                    Title = "Day 6: 8:00 p.m. – 9:00 p.m.",
                    AirDate = DateTime.Parse("March 26, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 16,
                    Title = "Day 6: 9:00 p.m. – 10:00 p.m.",
                    AirDate = DateTime.Parse("April 2, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 17,
                    Title = "Day 6: 10:00 p.m. – 11:00 p.m.",
                    AirDate = DateTime.Parse("April 9, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 18,
                    Title = "Day 6: 11:00 p.m. – 12:00 a.m.",
                    AirDate = DateTime.Parse("April 16, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 19,
                    Title = "Day 6: 12:00 a.m. – 1:00 a.m.",
                    AirDate = DateTime.Parse("April 23, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 20,
                    Title = "Day 6: 1:00 a.m. – 2:00 a.m.",
                    AirDate = DateTime.Parse("April 30, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 21,
                    Title = "Day 6: 2:00 a.m. – 3:00 a.m.",
                    AirDate = DateTime.Parse("May 7, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 22,
                    Title = "Day 6: 3:00 a.m. – 4:00 a.m.",
                    AirDate = DateTime.Parse("May 14, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 23,
                    Title = "Day 6: 4:00 a.m. – 5:00 a.m.",
                    AirDate = DateTime.Parse("May 21, 2007")
                },
                new Episode
                {
                    ShowID = 1,
                    SeasonID = 6,
                    EpisodeID = 24,
                    Title = "Day 6: 5:00 a.m. – 6:00 a.m.",
                    AirDate = DateTime.Parse("May 21, 2007")
                }
                #endregion
                );
            #endregion
        }
    }
}