
## Bu döküman, söz konusu projenin genel tanıtımı için hazırlanmıştır.

![](RoutingForUAV(Gif_1).gif)

### Rota Oluşturma işlemi
Kullanıcı tarafından, söz konusu programa aktarılan hedef nokta bilgileri, aralarındaki mesafeler Haversin metodu vasıtası ile hesaplandıktan sonra Dijkstra algoritması devreye girer ve en kısa rota, verilen hedef nokta değerleri doğrultusunda hesaplanır. Hesaplamalar yapıldıktan sonra Google Haritalar (Google Maps) ‘ ın sunduğu ‘gmapcontrol’ aracı üzerinde hesaplama sonuçları görsel olarak kullanıcıya yansıtılır. GmapControl aracı, Google Haritalar üzerinde çeşitli işlemler yapmamıza olanak sağlayan bir araçtır. Yukaridaki şekilde görüldüğü gibi harita üzerinde grafiksel işlemlerin gerçekleştirilmesine olanak sağlamaktadır.


![](RoutingForUAV(Gif_2).gif)

### Hedef Koordinat Detayı

İHA ‘lar hedef noktaları arası seyeder iken, yapması gereken dönüş açısı hesaplanır ve bu doğrultuda iconlar vasıtasıyla görsel olarak kullanıcıya yansıtılmaktadır. Aşağıdaki şekilde görülen hava aracı iconu hedef noktalar üzerinde yapılması gereken açı miktarı, iki nokta arasındaki açının hesaplanması yöntemi ile hesaplanıp döndürülmüştür.
Hedef noktalarının, minimum irtifa (rakım) bilgisi, dönüş açısı ve tam konum bilgisi gibi bilgilerin ayrıntılı ve bir arada incelenmesi olanağı kullanıcıya sunulmuştur. İkinci şekilde söz konusu bilgilerin tam teşhisi kullanıcının bilgise sunulmaktadır.


## Sürü Hareketi Simülasyonu ##


![](SwarmMotion.gif)

Günümüzde ağırlıklı olarak askeri görevlerde sürü hareketinden yararlanma durumu söz konusudur. Bu doğrultuda, bu çalışmanın konusu olarak belirtilen İHA ‘lar için rotalama ve sürü hareketi ‘nin gerçeklenmesi söz konusudur. Bu başlık altında oluşturulan rota doğrultusunda belirlenen çeşitli görevleri yerine getirme noktasında İHA ‘ların birlikte görev icrası simülasyon ortamında uygulanmıştır.
İHA ‘lar için uygulanan sürü hareketi uygulaması, simülasyon Unity (oyun motoru) hazırlanmıştır. Sürü Hareketi söz konusu olan simülasyonda sadece bir görev senaryosu üzerine yoğunlaşarak yazılmıştır. Söz konusu görev senaryosu hedef noktaların imhası üzerine seçilmiştir. Bu doğrultusa bölge tarama, keşif ve gözlem gibi farklı görev senaryoları uygulamaya açık bir sistem halinde çalıştırılabilmektedir. İHA ‘lar için yapılan rotalama işleminde kullanılan yöntemler simülasyonda kullanılmaktadır. 



***
> Bu tanıtım dökümanı projenin yüzeysel tanıtımı için hazırlanmıştır. Ayrıntılar ve proje dosyaları için lütfen iletişime geçin.
(Lisans Bitirme Projesi)
***
* E-posta: emramzn@gmail.com
- [LinkedLn](https://www.linkedin.com/in/emre-r-aydin-08864b14a/)
