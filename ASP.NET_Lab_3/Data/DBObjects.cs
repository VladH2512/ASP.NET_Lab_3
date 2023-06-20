using ASP.NET_Lab_3.Data.Models;

namespace ASP.NET_Lab_3.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Color.Any())
            {
                content.Color.AddRange(Colors.Select(c => c.Value));
            }

            if (!content.Company.Any())
            {
                content.Company.AddRange(Companies.Select(c => c.Value));
            }

            if (!content.Types.Any())
            {
                content.Types.AddRange(Typess.Select(c => c.Value));
            }


            if (!content.Clothes.Any())
            {
                content.AddRange(
                new Clothes
                {
                    Img = "/img/T-Shirt.jpg",
                    Name = "Black adidas T-shirt",
                    Description = "Manufacturer: adidas Originals\r\n"
                        + "Model: Adicolor Classics 3-Stripes Tee\r\n"
                        + "Article number: GN3495\r\n"
                        + "Material: 100% cotton\r\n"
                        + "Color: black / white",
                    Category = Categories["Male"],
                    Company = Companies["Adidas"],
                    Types = Typess["T-Shirt"],
                    Color = Colors["Black"],
                    Price = 787,

                },
                new Clothes
                {
                    Img = "/img/Skirt.jpg",
                    Name = "Red skirt made of dense corrugated cotton",
                    Description = "Red skirt made of dense corrugated cotton. It will look great with a blouse, and with a turtleneck, and with a sweater.\r\n"
                    + "- waistband with elastic at the back\r\n"
                    + "- no lining\r\n"
                    + "Made in Spain.",
                    Category = Categories["Childish"],
                    Company = Companies["Evika Kids"],
                    Types = Typess["Skirt"],
                    Color = Colors["Red"],
                    Price = 4200,

                },
                new Clothes
                {
                    Img = "/img/Dress.jpg",
                    Name = "Black dress",
                    Description = "Black dress with an open back",
                    Category = Categories["Female"],
                    Company = Companies["Prada"],
                    Types = Typess["Dress"],
                    Color = Colors["Black"],
                    Price = 51917,

                },
                new Clothes
                {
                    Img = "/img/CapGG1.jpg",
                    Name = "Classic Cap",
                    Description = "Gucci products are made with carefully selected materials. Please handle with care for longer product life. \r\n"
                    + "Cleaning by a professional only",
                    Category = Categories["Male"],
                    Company = Companies["Gucci"],
                    Types = Typess["Cap"],
                    Color = Colors["Black"],
                    Price = 11917,

                },
                new Clothes
                {
                    Img = "/img/T-Shirt1.jpg",
                    Name = "T-shirt Pink",
                    Description = "TeeStyled Style Number: TS6000"
                    + "AAA Style Number: 1301"
                    + "Style Weight: 6oz"
                    + "EASY Tear - Away Label",
                    Category = Categories["Childish"],
                    Company = Companies["Evika Kids"],
                    Types = Typess["T-Shirt"],
                    Color = Colors["Pink"],
                    Price = 917,

                },
                new Clothes
                {
                    Img = "/img/Jacket1.jpg",
                    Name = "Classic Leather Jacket",
                    Description = "The 2.5 Layer Lightweight Womens Waterproof Jackets is a lightweight jacket that is breathable while still protecting " +
                    "you from moderate to heavy amounts of rain with its fully waterproof fabric and taped seams. " +
                    "As well as an adjustable hood to ensure optimal protection.",
                    Category = Categories["Male"],
                    Company = Companies["Louis Vuitton"],
                    Types = Typess["Jacket"],
                    Color = Colors["Black"],
                    Price = 14010,

                },
                new Clothes
                {
                    Img = "/img/Jacket2.jpg",
                    Name = "Waterproof Jacket",
                    Description = "The Gorge Winter Waterproof Boots will keep your feet warm and protected during hikes, " +
                    "treks and long country walks. " +
                    "With IsoDry technology to keep your feet dry during wet weather, " +
                    "and an IsoTherm lining tested to temperatures of -10°c.",
                    Category = Categories["Female"],
                    Company = Companies["Louis Vuitton"],
                    Types = Typess["Jacket"],
                    Color = Colors["Green"],
                    Price = 18333,

                },
                new Clothes
                {
                    Img = "/img/Boots1.jpg",
                    Name = "Waterproof Outdoor Boots",
                    Description = "Sleek design with classic detailing, " +
                    "this stylish leather jacket features a tailored collar, " +
                    "welt pockets to stow your valuables and open cuff sleeves for mobility.",
                    Category = Categories["Male"],
                    Company = Companies["Louis Vuitton"],
                    Types = Typess["Boots"],
                    Color = Colors["Brown"],
                    Price = 10300,

                },
                new Clothes
                {
                    Img = "/img/T-Shirt.jpg",
                    Name = "Black adidas T-shirt",
                    Description = "Manufacturer: adidas Originals\r\n"
                        + "Model: Adicolor Classics 3-Stripes Tee\r\n"
                        + "Article number: GN3495\r\n"
                        + "Material: 100% cotton\r\n"
                        + "Color: black / white",
                    Category = Categories["Female"],
                    Company = Companies["Adidas"],
                    Types = Typess["T-Shirt"],
                    Color = Colors["Black"],
                    Price = 998,

                },
                new Clothes
                {
                    Img = "/img/Skirt.jpg",
                    Name = "Red skirt made of dense corrugated cotton",
                    Description = "Red skirt made of dense corrugated cotton. It will look great with a blouse, and with a turtleneck, and with a sweater.\r\n"
                    + "- waistband with elastic at the back\r\n"
                    + "- no lining\r\n"
                    + "Made in Spain.",
                    Category = Categories["Childish"],
                    Company = Companies["Evika Kids"],
                    Types = Typess["Skirt"],
                    Color = Colors["Red"],
                    Price = 3900,

                },
                new Clothes
                {
                    Img = "/img/Dress.jpg",
                    Name = "Black dress",
                    Description = "Black dress with an open back",
                    Category = Categories["Female"],
                    Company = Companies["Prada"],
                    Types = Typess["Dress"],
                    Color = Colors["Black"],
                    Price = 45317,

                },
                new Clothes
                {
                    Img = "/img/CapGG1.jpg",
                    Name = "Classic Cap",
                    Description = "Gucci products are made with carefully selected materials. Please handle with care for longer product life. \r\n"
                    + "Cleaning by a professional only",
                    Category = Categories["Male"],
                    Company = Companies["Gucci"],
                    Types = Typess["Cap"],
                    Color = Colors["Black"],
                    Price = 10907,

                },
                new Clothes
                {
                    Img = "/img/T-Shirt1.jpg",
                    Name = "T-shirt Pink",
                    Description = "TeeStyled Style Number: TS6000"
                    + "AAA Style Number: 1301"
                    + "Style Weight: 6oz"
                    + "EASY Tear - Away Label",
                    Category = Categories["Childish"],
                    Company = Companies["Evika Kids"],
                    Types = Typess["T-Shirt"],
                    Color = Colors["Pink"],
                    Price = 997,

                },
                new Clothes
                {
                    Img = "/img/Jacket1.jpg",
                    Name = "Classic Leather Jacket",
                    Description = "The 2.5 Layer Lightweight Womens Waterproof Jackets is a lightweight jacket that is breathable while still protecting " +
                    "you from moderate to heavy amounts of rain with its fully waterproof fabric and taped seams. " +
                    "As well as an adjustable hood to ensure optimal protection.",
                    Category = Categories["Male"],
                    Company = Companies["Louis Vuitton"],
                    Types = Typess["Jacket"],
                    Color = Colors["Black"],
                    Price = 13010,

                },
                new Clothes
                {
                    Img = "/img/Jacket2.jpg",
                    Name = "Waterproof Jacket",
                    Description = "The Gorge Winter Waterproof Boots will keep your feet warm and protected during hikes, " +
                    "treks and long country walks. " +
                    "With IsoDry technology to keep your feet dry during wet weather, " +
                    "and an IsoTherm lining tested to temperatures of -10°c.",
                    Category = Categories["Female"],
                    Company = Companies["Louis Vuitton"],
                    Types = Typess["Jacket"],
                    Color = Colors["Green"],
                    Price = 17993,

                },
                new Clothes
                {
                    Img = "/img/Boots1.jpg",
                    Name = "Waterproof Outdoor Boots",
                    Description = "Sleek design with classic detailing, " +
                    "this stylish leather jacket features a tailored collar, " +
                    "welt pockets to stow your valuables and open cuff sleeves for mobility.",
                    Category = Categories["Male"],
                    Company = Companies["Louis Vuitton"],
                    Types = Typess["Boots"],
                    Color = Colors["Brown"],
                    Price = 10000,

                },
                new Clothes
                {
                    Img = "/img/T-Shirt1.jpg",
                    Name = "T-shirt Pink",
                    Description = "TeeStyled Style Number: TS6000"
                    + "AAA Style Number: 1301"
                    + "Style Weight: 6oz"
                    + "EASY Tear - Away Label",
                    Category = Categories["Childish"],
                    Company = Companies["Evika Kids"],
                    Types = Typess["T-Shirt"],
                    Color = Colors["Pink"],
                    Price = 777,

                },
                new Clothes
                {
                    Img = "/img/Jacket1.jpg",
                    Name = "Classic Leather Jacket",
                    Description = "The 2.5 Layer Lightweight Womens Waterproof Jackets is a lightweight jacket that is breathable while still protecting " +
                    "you from moderate to heavy amounts of rain with its fully waterproof fabric and taped seams. " +
                    "As well as an adjustable hood to ensure optimal protection.",
                    Category = Categories["Male"],
                    Company = Companies["Louis Vuitton"],
                    Types = Typess["Jacket"],
                    Color = Colors["Black"],
                    Price = 14780,

                },
                new Clothes
                {
                    Img = "/img/Jacket2.jpg",
                    Name = "Waterproof Jacket",
                    Description = "The Gorge Winter Waterproof Boots will keep your feet warm and protected during hikes, " +
                    "treks and long country walks. " +
                    "With IsoDry technology to keep your feet dry during wet weather, " +
                    "and an IsoTherm lining tested to temperatures of -10°c.",
                    Category = Categories["Female"],
                    Company = Companies["Louis Vuitton"],
                    Types = Typess["Jacket"],
                    Color = Colors["Green"],
                    Price = 14433,

                },
                new Clothes
                {
                    Img = "/img/Boots1.jpg",
                    Name = "Waterproof Outdoor Boots",
                    Description = "Sleek design with classic detailing, " +
                    "this stylish leather jacket features a tailored collar, " +
                    "welt pockets to stow your valuables and open cuff sleeves for mobility.",
                    Category = Categories["Male"],
                    Company = Companies["Louis Vuitton"],
                    Types = Typess["Boots"],
                    Color = Colors["Brown"],
                    Price = 11310,

                }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        private static Dictionary<string, Color> color;
        private static Dictionary<string, Company> company;
        private static Dictionary<string, Types> types;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "Childish"},
                        new Category {CategoryName = "Male"},
                        new Category {CategoryName = "Female"},
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.CategoryName, el);
                    }
                }
                return category;
            }
        }

        public static Dictionary<string, Color> Colors
        {
            get
            {
                if (color == null)
                {
                    var list = new Color[]
                    {
                    new Color {ColorName = "Blue"},
                    new Color {ColorName = "Green"},
                    new Color {ColorName = "Red"},
                    new Color {ColorName = "Yellow"},
                    new Color {ColorName = "Brown"},
                    new Color {ColorName = "Purple"},
                    new Color {ColorName = "Orange"},
                    new Color {ColorName = "Pink"},
                    new Color {ColorName = "Violet"},
                    new Color {ColorName = "Grey"},
                    new Color {ColorName = "Black"},
                    new Color {ColorName = "White"},
                    new Color {ColorName = "Colorful"},
                    };

                    color = new Dictionary<string, Color>();
                    foreach (Color el in list)
                    {
                        color.Add(el.ColorName, el);
                    }
                }
                return color;
            }
        }

        public static Dictionary<string, Company> Companies
        {
            get
            {
                if (company == null)
                {
                    var list = new Company[]
                    {
                    new Company {Name = "Adidas"},
                    new Company {Name = "Gucci"},
                    new Company {Name = "Louis Vuitton"},
                    new Company {Name = "Prada"},
                    new Company {Name = "Dior"},
                    new Company {Name = "Evika Kids"},
                    new Company {Name = "Reporter Young"},
                    };

                    company = new Dictionary<string, Company>();
                    foreach (Company el in list)
                    {
                        company.Add(el.Name, el);
                    }
                }
                return company;
            }
        }

        public static Dictionary<string, Types> Typess
        {
            get
            {
                if (types == null)
                {
                    var list = new Types[]
                    {
                    new Types {TypesName = "T-Shirt"},
                    new Types {TypesName = "Jacket"},
                    new Types {TypesName = "Jeans"},
                    new Types {TypesName = "Dress"},
                    new Types {TypesName = "Socks"},
                    new Types {TypesName = "Boots"},
                    new Types {TypesName = "Cap"},
                    new Types {TypesName = "Shorts"},
                    new Types {TypesName = "Skirt"},
                    };

                    types = new Dictionary<string, Types>();
                    foreach (Types el in list)
                    {
                        types.Add(el.TypesName, el);
                    }
                }
                return types;
            }
        }
    }
}


               