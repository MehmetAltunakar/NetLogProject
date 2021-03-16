# NetLogProject
Proje:
Lojistik sektöründeki bir firma için ön önemli uygulamalardan biride operasyon süreçlerin mobil cihazlar üzerinden yapılabilmesi ve 
bu cihazlardan alınan bilgilerin web portalları üzerinden izlenebilmesidir. Operasyon süreçlerimizden araç bakım süreçlerimizi mobil cihazlarımız üzerine ve 
raporlamalarının ise web portal üzerine geçirmek istiyoruz. Bu nedenle mobil ve web için aşağıdaki API’lerini geliştirmeni rica ediyoruz. 

1)	Basic Login Authentication veya Token Doğrulaması ile giriş

2)	Tüm tablolar için CRUD fonksiyonlarının geliştirilmesi.

3)	Raporlama için gerekli gördüğünüz fonksiyonların geliştirilmesi. Raporlama ekranı için aşağıdaki rapor sayfası tasarımına bakabilirsiniz. 

4)	Yukarıdaki geliştirdiğiniz proje için test-case’leriniz neler olurdu? 

5)	Anlık 20K-30K arasında bir kullanıcı istediğinin geleceğini tahmin ediyorsanız servislerin devamlılığını sağlamak ve API cevaplarının performanslı olması için hangi yöntemleri izler testlerini nasıl yapardınız? Performans Testleri için kullandığınız örnek program veya araçlarınız var mı? Performans testlerinden geçemeyen bir servisi hızlandırmak için hangi yöntemleri uygularsınız?

//

1-Basic Login Authentication tamamlandı. Swagger üzerinden test edebilmeniz için denemeler yaptım ancak swaggerdan durum gerçekleşmedi.
  Swagger Login Authentication kodlarını tag commentlenmiş durumda paylaşıyorum.
  Basic Login Authentication için username:admin ve password:admin datası ile test gerçekleştirebilirsiniz.

2-CRUD oprerasyonları tamamlandı. Business katmanlarında kontrol sağlayabilirsiniz.

3-CRUD API leri geliştirildi. Spesifik bir API geliştirmedim.(Zaman Kısıtım sebebi ile.)

4-Test Case leri zaman kısıtımdan dolayı yazamadım.Unit test kodları yazılmadı. Swagger üzerinden operasyonları test edebilirsiniz.

5-Tek requestte işlem yapılabilecek şekilde API düzenlemesine geçilebilir.
  Cache mekanizması kurulabilir.
  Base repository ler daha kapsamlı hale getrilebilir.Örn:Sadece gerekli olan properties alınabilir.
  Kullanıcının beklemesini gerektirmeyen işlemler için ASYNC yapı kullanılabilir.

Projede Code First Mimarisi uyguland, PostgreSQL ve DBeaver kullanıldı.