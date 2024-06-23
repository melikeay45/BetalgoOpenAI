# BetalgoOpenAI Projesi 🚀

Herkese merhaba! 🙌

Bu proje, Betalgo OpenAI kütüphanesini kullanarak .NET ile nasıl yapay zeka tabanlı metin tamamlama yapılabileceğini gösteren bir örnektir. Projeyi indirip çalıştırmak için aşağıdaki adımları izleyebilirsiniz.

## Başlangıç 🛠️

### Gereksinimler

- [.NET SDK](https://dotnet.microsoft.com/download) (en az 6.0 versiyonu)
- [Visual Studio](https://visualstudio.microsoft.com/) veya [Visual Studio Code](https://code.visualstudio.com/)

### Kurulum 🔧

1. Projeyi klonlayın:

    ```sh
    git clone https://github.com/melikeay45/BetalgoOpenAI.git
    cd BetalgoOpenAI
    ```

2. Gerekli NuGet paketlerini yükleyin:

    ```sh
    dotnet restore
    ```

3. `appsettings.json` dosyasına kendi OpenAI API anahtarınızı ekleyin:

    ```json
    {
      "OpenAIApiKey": "Your_OpenAI_ApiKey"
    }
    ```

### Çalıştırma 🚀

Projeyi aşağıdaki komut ile çalıştırabilirsiniz:

```sh
dotnet run

Kullanım 📄
Projeyi çalıştırdıktan sonra, aşağıdaki API endpoint'ini kullanarak OpenAI'dan metin tamamlama isteğinde bulunabilirsiniz:

http
GET /api/OpenAI/GetAIResponseAsync?prompt=Merhaba dünya
Bu endpoint'e bir prompt parametresi göndererek yanıt alabilirsiniz.

Katkıda Bulunma 🤝
Katkıda bulunmak isterseniz, lütfen bir pull request açın veya bir issue oluşturun. Her türlü katkı ve geri bildirime açığız!


Kaynakça 📚
Betalgo OpenAI GitHub Deposu
OpenAI Resmi Dokümantasyon
İletişim 📬
Sorularınız veya geri bildirimleriniz varsa, lütfen yorum yapmaktan çekinmeyin veya bana ulaşın.

Teşekkür ederim! 🌸
