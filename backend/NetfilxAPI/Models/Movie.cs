namespace NetfilxAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public required string Genre { get; set; }
        public required string Title { get; set; }
        public required string Director { get; set; }
        public required List<string> Actors { get; set; }
        public required string Description { get; set; }
        public required string Poster { get; set; }
        public required string Trailer { get; set; }
        public Guid Guid { get; set; }
    }
}





"ID": 1,
        "GATUNEK": "Sci-Fi",
        "TYTUŁ FILMU": "TOP GUN: MAVERICK",
        "REZYSER": "Joseph Kosinski",
        "LISTA 5 AKTORÓW": [
            "Tom Cruise",
            "Miles Teller",
            "Jennifer Connelly",
            "Jon Hamm",
            "Glen Powell"
        ],
        "Opis (ok 5 zdań)": "Po ponad 20 latach służby w lotnictwie marynarki wojennej, Pete Maverick Mitchell zostaje wezwany do legendarnej szkoły Top Gun. Ma wyszkolić nowe pokolenie pilotów do niezwykle trudnej misji.",
        "link do postera": "https://fwcdn.pl/fpo/21/01/602101/8014563.3.jpg",
        "LINK do zwiastunu na YouTube": "https://www.youtube.com/watch?v=g4U4BQW9OEk&ab_channel=ParamountPictures"