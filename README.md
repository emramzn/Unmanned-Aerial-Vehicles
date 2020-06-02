
## Bu döküman söz konusu projenin genel olarak tanıtımı için hazırlanmıştır.
![](RoutingForUAV(Gif_1).gif)
### Rota Oluşturma işlemi
Kullanıcı tarafından, söz konusu programa aktarılan hedef nokta bilgileri, aralarındaki mesafeler Haversin metodu vasıtası ile hesaplandıktan sonra Dijkstra algoritması devreye girer ve en kısa rota, verilen hedef nokta değerleri doğrultusunda hesaplanır. Hesaplamalar yapıldıktan sonra Google Haritalar (Google Maps) ‘ ın sunduğu ‘gmapcontrol’ aracı üzerinde hesaplama sonuçları görsel olarak kullanıcıya yansıtılır. GmapControl aracı, Google Haritalar üzerinde çeşitli işlemler yapmamıza olanak sağlayan bir araçtır. Yukaridaki şekilde görüldüğü gibi harita üzerinde grafiksel işlemlerin gerçekleştirilmesine olanak sağlamaktadır.


![](RoutingForUAV(Gif_2).gif)

### Hedef Koordinat Detayı

İHA ‘lar hedef noktaları arası seyeder iken, yapması gereken dönüş açısı hesaplanır ve bu doğrultuda iconlar vasıtasıyla görsel olarak kullanıcıya yansıtılmaktadır. Aşağıdaki şekilde görülen hava aracı iconu hedef noktalar üzerinde yapılması gereken açı miktarı, iki nokta arasındaki açının hesaplanması yöntemi ile hesaplanıp döndürülmüştür.
Hedef noktalarının, minimum irtifa (rakım) bilgisi, dönüş açısı ve tam konum bilgisi gibi bilgilerin ayrıntılı ve bir arada incelenmesi olanağı kullanıcıya sunulmuştur. İkinci şekilde söz konusu bilgilerin tam teşhisi kullanıcının bilgise sunulmaktadır.
