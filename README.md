![Image08](https://github.com/user-attachments/assets/8d9a865e-5c15-4020-bb63-f3d44ff81022)![Image01](https://github.com/user-attachments/assets/439b9630-c9ff-43b9-800c-8f3157965180)-- Bu Projeyi CQRS Design Pattern ve MediatR kütüphanesini kullanarak Mediator Design ile geliştirdik

📌 Rotaları Listeledik. <br>

📌 Rotalara ait detay sayfası oluşturduk.<br>

📌 Admin tarafında site içinde gerçekleşmek üzere bütün CRUD işlemlerini CQRS ve MeditaR ile gerçekleştirdik.<br>

📌 AutoMapper ile verileri eşledik.<br>

📌 Code first yapısını kullandık.<br>

📌 Projeyi ViewComponentlere ayırdık böylece kodları daha okunabilir hale getirdik.<br>

📌 Entitylere özgü methodlar yazdık.<br>

<hr>

<h1>Kısaca CQRS Nedir ? </h1>

 ☆ Bu desenin temel amacı, okuma ve yazma işlemlerini birinden ayırarak sistemi daha esnek, ölçeklenebilir ve performanslı hale getirmektir.
 
 <ul>
   <li>Commands : Temel olarak veri kaynağındaki verinin değiştirilmesini ifade eder. (insert update delete gibi bir post isteğinin propertysini tutar)</li>
   <li>Queries : Bir get isteğinin propertyisin tutar </li>
   <li>Results : Verilerin çıktısını burada görürüz (özünde view model ve dto gibi çalışır)</li>
   <li>Handlers : Result veya command isteklerinin işlendiği yerdir.</li>
 </ul>

<h1>Eklenen son 3 rota listesi</h1>

![Image03](https://github.com/user-attachments/assets/4d1c179d-371b-4d48-9819-83de7db02676)

📌 Veriler entitye özgü method yazılarak cqrs pattern kullanılarak listelenmiştir.

📌 İstenilen rotanın resimine tıklayarak rota detay sayfasına geçiş geçiş sağlanılıyor.

<h1>Rota Detay Sayfası</h1>

![Image11](https://github.com/user-attachments/assets/0892dc4d-4d71-429e-8ac9-e0e8f316eb37)

📌 Seçilen rotanın bilgileri gösteriliyor


<h1>Admin dashboard alanı</h1>

![Image08](https://github.com/user-attachments/assets/86969f36-be68-41c6-9bc3-2adc57c21bf1)

📌 Site içinde bulunan verilerin sayıları, referlanslar ve son eklenen 6 rotanın bilgileri burada listeleniyor.

