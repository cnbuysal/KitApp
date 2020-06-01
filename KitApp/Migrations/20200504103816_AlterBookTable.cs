using Microsoft.EntityFrameworkCore.Migrations;


namespace KitApp.Migrations
{
    public partial class AlterBookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "Name", "Price" },
                values: new object[] { 7, "'Yüzüklerin Efendisi' son yüzyılın en çok okunan yüz kitabı arasında en başta geliyor; bilimkurgu, fantezi, polisiye, best-seller ya da ana akım demeden, tüm edebiyat türleri arasında tartışmasız bir önderliğe sahip. Bir açıdan bakarsanız bir fantezi romanı, başka bir açıdan baktığınızda, insanlık durumu, sorumluluk, iktidar ve savaş üzerine bir roman. Bir yolculuk, bir büyüme öyküsü; fedakârlık ve dostluk üzerine, hırs ve ihanet üzerine bir roman.", "~/images/BookThumbnails/lotr1.jpg", "", "Yüzüklerin Efendisi - I - Yüzük Kardeşliği", 48.00m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "Name", "PageNumber", "Price", "PublicationDate", "Publisher" },
                values: new object[] { "J.R.R. Tolkien", 7, "Dünya ikiye bölünmüştür, denir Tolkien'ın yapıtı söz konusu olduğunda: Yüzüklerin Efendisi'ni okumuş olanlar ve okuyacak olanlar. Artık Türkiye'li okur da okumuş olanlar tarafına geçebilecek! 'Yüzüklerin Efendisi' son yüzyılın en çok okunan yüz kitabı arasında en başta geliyor; bilimkurgu, fantezi, polisiye, best-seller yada ana akım demeden, tüm edebiyat türleri arasında tartışmasız bir önderliğe sahip. Bir açıdan bakarsanız bir fantezi romanı, başka bir açıdan baktığınızda, insanlık durumu, sorumluluk, iktidar ve savaş üzerine bir roman. Bir yolculuk, bir büyüme öyküsü; fedakarlık ve dostluk üzerine, hırs ve ihanet üzerine bir roman.Bu ciltte Yüzük kardeşliği dağılıyor. Frodo ve Sam Yüzük'te birlikte Mordor'un kapılarından geçmeye çlaşırken yeni bir yola arkadaşı ediniyorlar. Orklara esir düşen Merry ve Pippin, Orta Dünya'nın en lmeski ırkıyla tanışıyorlar. Aragorn, Gimli ve Legolas ise, Orta Dünya'nın kaderini çizecek büyük savaşların ilkine katılıyorlar... ", "~/images/BookThumbnails/lotr2.jpg", "", "Yüzüklerin Efendisi - II - İki Kule", "416", 40.50m, "2014", "Metis Yayıncılık" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Dimensions", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPreferredBook", "Language", "Name", "PageNumber", "Price", "PublicationDate", "Publisher" },
                values: new object[,]
                {
                    { 3, "J.R.R. Tolkien", 7, "Yüzüklerin Efendisi son yüzyılın en çok okunan yüz kitabı arasında en başta geliyor. Türkçe basımının ilk iki kitabı Yüzük Kardeşliği ve İki Kule, bu ilginin evrenselliğini kanıtladı. Polisiye ya da bilimkurgu meraklıları, şiir, roman ve öykü okurları, hep birlikte Frodo, Sam, Merry, Pippin, Aragorn ve Gandalf'ın maceralarını okumaya, 'Orta Dünya'da yaşamaya başladılar.Üçüncü kitap Kralın Dönüşü ile birlikte Yüzüklerin Efendisi tamamlanıyor: Bu kısımda Karanlıklar Efendisi ile Yüzük Kardeşliği, iki cephede karşı karşıya geliyorlar. Frodo ve Sam ellerinde hepsine hükmedecek Tek Yüzük ile Mordor'un içine, karanlığın kalbine doğru bir yolculuk yaparken, diğerleri de karanlığa karşı son cephe olan Gondor'da umutsuz bir savunmaya girişiyorlar...", "13x20", "~/images/BookThumbnails/lotr3.jpg", "", 19, false, "Türkçe", "Yüzüklerin Efendisi - III - Kralın Dönüşü", "408", 40.50m, "2015", "Metis Yayıncılık" },
                    { 4, "Cemal Süreya", 5, "Cemal Süreya, ilk kitabı Üvercinka 1958'de çıktığında, 27 yaşında, ilk şiiri (\"Şarkısı Beyaz\") daha beş yıl önce yayımlanmış genç bir şairdi. Bu kitapla çağcıl Türk şiirinin en çok konuşulan, en çok tartışılan akımlarından İkinci Yeni'nin öncülerinden biri olacağını ne kendisi ne de bir başkası bilebilirdi.", null, "~/images/BookThumbnails/uvercinka.jpg", "", 5, false, "Türkçe", "Üvercinka", "64", 6m, "2014", "Yapı Kredi Yayınları" },
                    { 5, "Ali Lidar", 5, "Linç Çağı’nda, Şirintepe Parkı’nda, heybende meleğin emanetleri, çölleri ve karlı ovaları aşacak, yangınlara tanık olacaksın, soyut atların gölgesinde soluklanıp, şirk sınırlarını zorlarken, deliydim geçti de geç.Bu yolculukta en çok kendine tanık olacaksın; ayrılık öfke ve keder yoldaşın olacak, müzevirler dünyanı karartacak. Ali Lidar şiirleriyle seni, sana anlatacak.Dünyanın yükü kendisinden ağırsa, tek çare terazinin kefesine bir tutam adalet koymaktır.Aslında Herkes Haklı, anılardan bir kırkyama…", "13.5x21", "~/images/BookThumbnails/aslindaherkeshakli.jpg", "", 48, true, "Türkçe", "Aslında Herkes Haklı", "128", 10.22m, "2018", "İthaki Yayınları" },
                    { 6, "Jean-Christophe Grange", 8, "Kara orman’da son av başladı… ardında hiçbir iz bırakmayan avcı kim? Komiser Niémans,yardımcısı Ivana Bogdović’le Alsace bölgesinde işlenen vahşi bir cinayeti çözmeye gider.Kendi karanlık geçmişlerini de yanlarında götüren iki polis,Kara Orman’da saklanan bir sırrın peşine düşerler.Kızıl Nehirler’in başkahramanı Niémans’ın dönüşünü müjdeleyen Son Av,kökeni Nazi Almanyası’na kadar giden sürprizlerle dolu bir gerilim…", "14x23", "~/images/BookThumbnails/sonav.jpg", "", 108, true, "Türkçe", "Son Av", "304", 27.36m, "2020", "Doğan Kitap" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "Bir yolculuk, bir büyüme öyküsü; fedakârlık ve dostluk üzerine, hırs ve ihanet üzerine bir roman.", "~/images/lotr.jpg", "~/images/lotr.jpg", "Yüzük Kardeşliği", 51.20m });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "Name", "PageNumber", "Price", "PublicationDate", "Publisher" },
                values: new object[] { "George R. R. Martin", 1, "Yazların on yıllar, kışların bir insan ömrü sürebildiği diyarda, dehşetli ve soğuk zamanlar yaklaşmaktadır. Kışyarı'nın kuzeyindeki buzul topraklarda, Yedi Krallık'ı koruyan Sur'un ötesinde tehditkâr doğaüstü güçler toplanmaktadır. ", "~/images/taht.jpg", "~/images/taht.jpg", "Taht Oyunları", "850", 36.75m, "2011", "Epsilon Yayınevi" });
        }
    }
}
