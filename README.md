# Hangfire

Hangfire, arka planda çalışması istenen bazı işlerin yaratılmasında, yürütülmesinde ve yönetilmesinde kullanıcılara yardımcı olan açık kaynaklı bir kütüphanedir.


## Hangfire'a Neden İhtiyaç Duyulur?

İş akış süreçlerinizde veya uygulamalarınızın bir bölümünde, bazı işlerin arka planda asenkron olarak gerçekleşmesi gereken durumlar olabilir. Sizin belirleyeceğiniz bu işlerin, yine sizin belirleyeceğiniz bir takvim doğrultusunda, belirli aralıklarla tekrarlanmasını sağlar Hangfire kütüphanesi.

#### Hangfire Kullanım Örnekleri

 **1.** Uygulamanızın kullanıcılarına düzenli aralıklarla bildirim veya mail göndermek isterseniz bunu Hangfire aracılığı ile kolaylıkla gerçekleştirebilirsiniz. 
 
 **2.** Veritabanı yedekleme işlemini bir Hangfire görevine çevirerek sizin belirlediğiniz aralıklarla uygulamanızın veritabanının asenkron bir şekilde yedeklenmesini sağlayabilirsiniz.

## Hangfire Avantajları

 - Sunduğu Dashboard sayesinde daha kolay bir yönetim imkanı sağlar.
 - Uygulamanızdan bağımsız bir şekilde çalışabilir.
 - Kendisine verilen her işin detaylı bilgisini veri tabanında tuttuğu için bir bütünlük sağlar ve herhangi bir işin yürütülmesinde sorun yaşanması durumunda tekrar tekrar denenmesini sağlar.

## Hangfire Görev Çeşitleri

 **1. Fire and Forget:** Bir kez ve anında çalışacak olan görev çeşididir. 
 
 **2. Delayed:** Belirtilen sürenin sonunda bir kez çalışacak olan görev çeşididir. 
 
 **3. Recurring:** Recursive olarak, kullanıcı tarafından belirlenen takvime göre devamlı çalışacak olan görev çeşididir. 
 
 **4. Continuations:** Daha önceden tanımlanmış olan bir görevin başarılı şekilde çalışması durumunda çalışacak olan görev çeşididir.
