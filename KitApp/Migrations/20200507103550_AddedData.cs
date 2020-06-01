using Microsoft.EntityFrameworkCore.Migrations;

namespace KitApp.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Language", "Name", "PageNumber", "PublicationDate", "Publisher" },
                values: new object[] { "The opening novel of The Lord of the Rings--the greatest fantasy epic of all time--which continues in The Two Towers and The Return of the King. Nominated as one of America's best-loved novels by PBS's The Great American Read The dark, fearsome Ringwraiths are searching for a Hobbit. Frodo Baggins knows that they are seeking him and the Ring he bears--the Ring of Power that will enable evil Sauron to destroy all that is good in Middle-earth. Now it is up to Frodo and his faithful servant, Sam, with a small band of companions, to carry the Ring to the one place it can be destroyed: Mount Doom, in the very center of Sauron's realm.", "English", "The Fellowship of the Ring", "480", "1989", "Random House USA Inc" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Language", "Name", "PublicationDate", "Publisher" },
                values: new object[] { "Building on the story begun in The Hobbit and The Fellowship of the Ring this is the second part of Tolkien's epic masterpiece, The Lord of the Rings, featuring a striking black cover based on Tolkien's own design, the definitive text, and a detailed map of Middle-earth.Frodo and the Companions of the Ring have been beset by danger during their quest to prevent the Ruling Ring from falling into the hands of the Dark Lord by destroying it in the Cracks of Doom.They have lost the wizard,Gandalf, in the battle with an evil spirit in the Mines of Moria; and at the Falls of Rauros, Boromir, seduced by the power of the Ring, tried to seize it by force.While Frodo and Sam made their escape the rest of the company were attacked by Orcs.", "English", "The Two Towers", "1991", "HarperCollins Publishers" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Language", "Name", "PublicationDate", "Publisher" },
                values: new object[] { "The awesome conclusion to The Lord of the Rings--the greatest fantasy epic of all time--which began in The Fellowship of the Ring and The Two Towers. Nominated as one of America's best-loved novels by PBS's The Great American Read While the evil might of the Dark Lord Sauron swarms out to conquer all Middle-earth, Frodo and Sam struggle deep into Mordor, seat of Sauron's power. To defeat the Dark Lord, the One Ring, ruler of all the accursed Rings of Power, must be destroyed in the fires of Mount Doom. But the way is impossibly hard, and Frodo is weakening. Weighed down by the compulsion of the Ring, he begins finally to despair.", "English", "The Return of the King", "1993", "Del Rey Books" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Language",
                value: "Turkish");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Language",
                value: "Turkish");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Language",
                value: "Turkish");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Dimensions", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPreferredBook", "Language", "Name", "PageNumber", "Price", "PublicationDate", "Publisher" },
                values: new object[,]
                {
                    { 7, "Brandon Sanderson", 9, "Spensa's world has been under attack for hundreds of years. An alien race called the Krell leads onslaught after onslaught from the sky in a never-ending campaign to destroy humankind. Humanity's only defense is to take to their ships and fight the enemy in the skies. Pilots have become the heroes of what's left of the human race.Spensa has always dreamed of being one of them; of soaring above Earth and proving her bravery. But her fate is intertwined with her father's - a pilot who was killed years ago when he abruptly deserted his team, placing Spensa's chances of attending flight school somewhere between slim and none.No one will let Spensa forget what her father did, but she is still determined to fly. And the Krell just made that a possibility. They've doubled their fleet, making Spensa's world twice as dangerous. . .but their desperation to survive might just take her skyward. . .", "16x23.8", "~/images/BookThumbnails/skyward.jpg", "", 2, true, "English", "Skyward", "528 ", 67.35m, "2019", "Orion Publishing Co" },
                    { 12, "George R. R. Martin", 7, "The never-before-seen history of Westeros and the lands beyond. With hundreds of pages of all-new material from George R.R. Martin.If the past is prologue,then George R.R.Martin's masterwork-the most inventive and entertaining fantasy saga of our time-warrants one hell of an introduction. At long last, it has arrived with THE WORLD OF ICE AND FIRE.George R.R.Martin, in collaboration with Elio M.Garcia,Jr.and Linda Antonsson,has written a comprehensive history of the Seven Kingdoms,featuring the epic battles,bitter rivalries,and daring rebellions that lead up to the events in the bestselling A Song of Ice and Fire series.Collected within this volume is the accumulated knowledge,scholarly speculation,and inherited folk tales of maesters and septons,maegi and singers,including over 170 full - colour illustrations and maps,family trees for the Houses Stark, Lannister and Targaryen, and in-depth explanations of the history and culture of Westeros.", "15.9x24", "~/images/BookThumbnails/icefire.jpg", "", 150, true, "English", "The World of Ice and Fire", "336", 246.32m, "2014", "HarperCollins" },
                    { 11, "George R. R. Martin", 7, "From the masterly imagination behind A Game of Thrones - one of the greatest fantasy epics of all time and an unmissable HBO hit series - comes a definitive history of Westeros’s past as told by Archmaester Gyldayn.Unravelling events that led to A Song of Ice and Fire,Fire and Blood is the first volume of the definitive two - part history of the Targaryens in Westeros.Revealing long - buried secrets and untold lasting enmity,it sets the scene for the heart-stopping series conclusion, The Winds of Winter.300 years before the events of A Song of Ice and Fire, long before the schism that set the houses of Westeros at each other’s throats, one house ruled supreme and indomitable.House Targaryen, the house of the last remaining dragonlords.", "15.9x24", "~/images/BookThumbnails/fireblood.jpg", "", 147, true, "English", "Fire & Blood", "704", 184.72m, "2018", "HarperCollins" },
                    { 10, "Ayşen Bakioğlu", 2, "Dünya nüfusunun beşte birini barındıran bir ülke olarak Çin, dünya eğitim kaynaklarının sadece %2'si ile tüm dünyadaki öğrencilerin %26'sına hizmet vermektedir. 1940'larda nüfusunun %80'i eğitimsiz, 1980'lerde 15 yaş üstü nüfusun ortalama eğitim yılı sadece 7.8 yıl iken, günümüzde okuryazarlık oranı %93'ün üstüne çıkmış, farklı kademelerdeki okullarda, yaklaşık 12 milyon öğretmen 250 milyon öğrenciye eğitim vermektedir. 23 milyonluk nüfusu ülkesinin %1'ine, yüzölçümü %0,06'sına denk gelen Şangay ise, tek başına Çin'in toplam gelirinin sekizde birini karşılamakta; ülkenin ihracat ve ithalat hacminin dörtte birini gerçekleştirmektedir. 15 yaşındaki öğrencilerin gerçek yaşam koşullarında bilgilerini ne ölçüde kullanabildiklerini sınayan PISA sınavlarında, ilk yıllarda Finlandiya üst sıralarda yer alırken, 2009 ve 2012 PISA sınavlarında ilk sıralarda Finlandiya'nın yanında tamamı Asyalı Şangay (Çin), Hong Kong (Çin), Güney Kore, Singapur, Tayvan (Çin), Makao (Çin) ve Japonya gibi ülkelerin/ekonomilerin yer alması, 21'inci yüzyıl için “Asya yüzyılı” nitelemesinin pekişmesine yol açmıştır. ", "16x23,5", "~/images/BookThumbnails/cin.jpg", "", 13, true, "Turkish", "Çin’de Eğitim", "246  ", 24.64m, "2017", "Nobel Akademik Yayıncılık" },
                    { 9, "Mark Murphy", 2, "Eğitim araştırmacıları çalışmalarında farklı teorisyenlerden faydalanıyor olsalar da, bir kaçının eğitim için daha farklı bir öneme sahip oldukları söylenebilir. Karl Marx, Antonio   Gramsci, John Dewey ve Paulo Freire gibi düşünürler bir önceki nesli etkilerken, daha çağdaş tartışmaların büyük bir kısmı Michel Foucault, Jürgen Habermas, Pierre Bourdieu ve Jacques Derrida gibi düşünürlerin fikirleri etrafında şekillenmektedir. Her ne kadar bu düşünürlerin eğitim araştırmaları üzerindeki etkileri son yıllarda giderek büyüyor olsa da hem orijinal çalışmaları, hem de bu çalışmaların eğitime uygulanması eğitimciler için çeşitli zorlukları beraberinde getirmektedir. Söz konusu bu zorluklar, ileri düzeydeki uygulayıcılara hitap eden uygun okuma materyallerinin eksikliği dolayısıyla daha da derinleşmektedir.", "13,5x21", "~/images/BookThumbnails/sosyalteori.jpg", "", 82, false, "Turkish", "Sosyal Teori ve Eğitim", "120  ", 33.25m, "2018", "Eğitim Kitabevi Yayınları" },
                    { 8, "Kobe Bryant", 1, "The Mamba Mentality: How I Play is Kobe Bryant's personal perspective of his life and career on the basketball court and his exceptional, insightful style of playing the game--a fitting legacy from the late Los Angeles Laker superstar.In the wake of his retirement from professional basketball,Kobe \"The Black Mamba\" Bryant decided to share his vast knowledge and understanding of the game to take readers on an unprecedented journey to the core of the legendary \"Mamba mentality.\" Citing an obligation and an opportunity to teach young players,hardcore fans", " 23.5x28.7", "~/images/BookThumbnails/mamba.jpg", "", 22, true, "English", "The Mamba Mentality : How I Play", "208  ", 194.50m, "2020", "Farrar, Straus & Giroux Inc" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryName",
                value: "Biography");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryName",
                value: "Education");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryName",
                value: "Hobby");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "ParentCategoryId" },
                values: new object[] { "Poetry", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "ParentCategoryId" },
                values: new object[] { "Novel", null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CategoryName",
                value: "Fantasy");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CategoryName",
                value: "Crime & Thriller");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CategoryName",
                value: "Science Fiction");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Language", "Name", "PageNumber", "PublicationDate", "Publisher" },
                values: new object[] { "'Yüzüklerin Efendisi' son yüzyılın en çok okunan yüz kitabı arasında en başta geliyor; bilimkurgu, fantezi, polisiye, best-seller ya da ana akım demeden, tüm edebiyat türleri arasında tartışmasız bir önderliğe sahip. Bir açıdan bakarsanız bir fantezi romanı, başka bir açıdan baktığınızda, insanlık durumu, sorumluluk, iktidar ve savaş üzerine bir roman. Bir yolculuk, bir büyüme öyküsü; fedakârlık ve dostluk üzerine, hırs ve ihanet üzerine bir roman.", "Türkçe", "Yüzüklerin Efendisi - I - Yüzük Kardeşliği", "496", "2000", "Metis Yayıncılık" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Language", "Name", "PublicationDate", "Publisher" },
                values: new object[] { "Dünya ikiye bölünmüştür, denir Tolkien'ın yapıtı söz konusu olduğunda: Yüzüklerin Efendisi'ni okumuş olanlar ve okuyacak olanlar. Artık Türkiye'li okur da okumuş olanlar tarafına geçebilecek! 'Yüzüklerin Efendisi' son yüzyılın en çok okunan yüz kitabı arasında en başta geliyor; bilimkurgu, fantezi, polisiye, best-seller yada ana akım demeden, tüm edebiyat türleri arasında tartışmasız bir önderliğe sahip. Bir açıdan bakarsanız bir fantezi romanı, başka bir açıdan baktığınızda, insanlık durumu, sorumluluk, iktidar ve savaş üzerine bir roman. Bir yolculuk, bir büyüme öyküsü; fedakarlık ve dostluk üzerine, hırs ve ihanet üzerine bir roman.Bu ciltte Yüzük kardeşliği dağılıyor. Frodo ve Sam Yüzük'te birlikte Mordor'un kapılarından geçmeye çlaşırken yeni bir yola arkadaşı ediniyorlar. Orklara esir düşen Merry ve Pippin, Orta Dünya'nın en lmeski ırkıyla tanışıyorlar. Aragorn, Gimli ve Legolas ise, Orta Dünya'nın kaderini çizecek büyük savaşların ilkine katılıyorlar... ", "Türkçe", "Yüzüklerin Efendisi - II - İki Kule", "2014", "Metis Yayıncılık" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Language", "Name", "PublicationDate", "Publisher" },
                values: new object[] { "Yüzüklerin Efendisi son yüzyılın en çok okunan yüz kitabı arasında en başta geliyor. Türkçe basımının ilk iki kitabı Yüzük Kardeşliği ve İki Kule, bu ilginin evrenselliğini kanıtladı. Polisiye ya da bilimkurgu meraklıları, şiir, roman ve öykü okurları, hep birlikte Frodo, Sam, Merry, Pippin, Aragorn ve Gandalf'ın maceralarını okumaya, 'Orta Dünya'da yaşamaya başladılar.Üçüncü kitap Kralın Dönüşü ile birlikte Yüzüklerin Efendisi tamamlanıyor: Bu kısımda Karanlıklar Efendisi ile Yüzük Kardeşliği, iki cephede karşı karşıya geliyorlar. Frodo ve Sam ellerinde hepsine hükmedecek Tek Yüzük ile Mordor'un içine, karanlığın kalbine doğru bir yolculuk yaparken, diğerleri de karanlığa karşı son cephe olan Gondor'da umutsuz bir savunmaya girişiyorlar...", "Türkçe", "Yüzüklerin Efendisi - III - Kralın Dönüşü", "2015", "Metis Yayıncılık" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Language",
                value: "Türkçe");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Language",
                value: "Türkçe");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Language",
                value: "Türkçe");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryName",
                value: "Edebiyat");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryName",
                value: "Eğitim");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategoryName",
                value: "Hobi");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "ParentCategoryId" },
                values: new object[] { "Şiir", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "ParentCategoryId" },
                values: new object[] { "Roman", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CategoryName",
                value: "Fantastik");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CategoryName",
                value: "Polisiye");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CategoryName",
                value: "Bilim Kurgu");
        }
    }
}
