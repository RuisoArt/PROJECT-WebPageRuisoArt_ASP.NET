using ruisoArtPage.Models;
using ruisoArtPage.Data;
using ruisoArtPage.Data.Enum;
using Microsoft.AspNetCore.Identity;
using ruisoArtPage.Data.Static;

namespace ruisoArtPage.Data{
    public class AppDbInitializer{

        public void Seed(IApplicationBuilder applicationBuilder){
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()){
               
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();
/*
                //Item
                if(!context.Item.Any()){
                    context.Item.AddRange(new List<Item>(){
                        new Item(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/product2.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            shoppingWay = "Servientrega o medio similar",
                            //TypeId = 1
                        },
                        new Item(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/product1.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            shoppingWay = "Servientrega o medio similar",
                            //TypeId = 3
                        },
                        new Item(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/product2.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            shoppingWay = "Servientrega o medio similar",
                            //TypeId = 4
                        },
                        new Item(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/product1.png",
                            price = 123456,
                            tax = 0.17,
                            quantity = 4,
                            shoppingWay = "Servientrega o medio similar",
                            //TypeId = 2
                        }
                    });
                    context.SaveChanges();
                }
            
                //Type
                if(!context.MyType.Any()){
                    context.MyType.AddRange(new List<MyType>(){
                        new MyType(){
                            name = ListTypes.Product
                        },
                        new MyType(){
                            name = ListTypes.Commission
                        },
                        new MyType(){
                            name = ListTypes.Product
                        },
                        new MyType(){
                            name = ListTypes.Commission
                        }
                    });
                    context.SaveChanges();
                }
*/
                //Provider
                if(!context.Provider.Any()){
                    context.Provider.AddRange(new List<Provider>(){
                        new Provider(){
                            name = "Luis Felipe Narvaez Gomez",
                            description = "Aqui podria ir mi Descripcion :v",
                            image = "http://localhost/images/OIP.jpg",
                            phone = "(aja) aja aja aja",
                            link = "https://linktr.ee/onruisoart",
                            email = "ruiso.illustration@gmail.com",
                            socialRed0 = "https://linktr.ee/onruisoart",
                            socialRed1 = "https://www.instagram.com/onruisoart/",
                            socialRed2 = "https://www.facebook.com/ruisoart",
                            socialRed3 = "https://www.tiktok.com/@ruisoart",
                            socialRed4 = "https://twitter.com/RuisoArt",
                            socialRed5 = "https://www.youtube.com/channel/UCPSeMEXj7ZhJdNjXedrgTug",
                            socialRed6 = "https://github.com/RuisoArt",
                            socialRed7 = "https://scienti.minciencias.gov.co/cvlac/visualizador/generarCurriculoCv.do?cod_rh=0001701491",
                            socialRed8 = "https://www.linkedin.com/in/luis-felipe-narv%C3%A1ez-g%C3%B3mez-9a1025219/",
                            socialRed9 = "https://ruisoart.tumblr.com/",
                            socialRed10 = "https://www.deviantart.com/onruisoart",
                            socialRed11 = "https://user.zepeto.me/ruisoart?referrer=ruisoart&language=es",
                            socialRed12 = "",
                            socialRed13 = "",
                            socialRed14 = "",
                            socialRed15 = "",
                            socialRed16 = "",
                            socialRed17 = "",
                            socialRed18 = "",
                            socialRed19 = "",
                        },
                    });
                    context.SaveChanges();
                }

                //Product
                if(!context.Product.Any()){
                    context.Product.AddRange(new List<Product>(){
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/cup.jpg",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/product2.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/product2.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/product2.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img1.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img2.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img3.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img4.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img5.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img6.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img7.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img8.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img9.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img20.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img11.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img12.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img13.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img14.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img15.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img16.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img17.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img18.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img19.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img20.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img21.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img22.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img23.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img24.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img25.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img26.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img27.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img28.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img29.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img30.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img31.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img32.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img33.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img34.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img35.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img36.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img37.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img38.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img39.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img40.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img41.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img42.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img43.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img44.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img45.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img46.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img47.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img48.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img49.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/img50.png",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        new Product(){
                            name = "Dado 20 caras de Risina, Tema Floral",
                            description = "Elaborado en Resina Epoxi.",
                            image = "http://localhost/images/merch/cup.jpg",
                            price = 123456.78,
                            tax = 0.17,
                            quantity = 4,
                            //
                            shoppingWay = "Servientrega o medio similar",
                            creationDate = DateTime.Now.AddDays(-10),
                            externalLink = "https://www.instagram.com/p/Cr_8QP0vcyx/",
                            nftLink = "",
                            color  = "Resina Transparente con tema Floral Rosado",
                            sizeCup = ListCups.Default,
                            modelClothes = ListClothes.Default,
                            sizeClothes = ListSizeClothes.Default,
                            sizeNotepad = ListNotepad.Default,
                            season = "primavera",
                            status = ListStaus.Sale,
                            sizePrint = "",
                            sizePaper = ListPaper.Default,
                            formatImage = ListFormatImage.Default,
                            sizeBookMarker = ListBookMarker.Default,
                            rolDice = ListDice.d20,
                            sizeDice = "20cm",
                            ProviderId = 1
                        },
                        
                    });
                    context.SaveChanges();
                }

                //Commission
                if(!context.Commission.Any()){
                    context.Commission.AddRange(new List<Commission>(){
                        new Commission(){
                            Tittle = "Dibujo en tradicional de mi mascota",
                            description = "Modelun dibujo de mi mascota en tamaño A4 con buen detalle al estilo de formas transversas tupiditas como sabes",
                            AproxPrice = 87.98,
                            Email = "cliente_aja@email.com",
                            PersonName = "Nombre Anonimo",
                            PersonLastName = "Apellido Anonimo",
                            ImageReference = "http://localhost/images/R.jpg"
                            //TypeId = 2
                        },
                        new Commission(){
                            Tittle = "Dibujo en tradicional de mi mascota 2",
                            description = "Modelun dibujo de mi mascota en tamaño A4 con buen detalle al estilo de formas transversas tupiditas como sabes",
                            AproxPrice = 87.98,
                            Email = "cliente_aja@email.com",
                            PersonName = "Nombre Anonimo",
                            PersonLastName = "Apellido Anonimo",
                            ImageReference = "http://localhost/images/R.jpg"
                            //TypeId = 2
                        },
                        new Commission(){
                            Tittle = "Dibujo en tradicional de mi mascota",
                            description = "Modelun dibujo de mi mascota en tamaño A4 con buen detalle al estilo de formas transversas tupiditas como sabes",
                            AproxPrice = 87.98,
                            Email = "cliente_aja@email.com",
                            PersonName = "Nombre Anonimo",
                            PersonLastName = "Apellido Anonimo",
                            ImageReference = "http://localhost/images/R.jpg"
                            //TypeId = 2
                        },
                        new Commission(){
                            Tittle = "Dibujo en tradicional de mi mascota",
                            description = "Modelun dibujo de mi mascota en tamaño A4 con buen detalle al estilo de formas transversas tupiditas como sabes",
                            AproxPrice = 87.98,
                            Email = "client_aja@email.com",
                            PersonName = "Nombre Anonimo",
                            PersonLastName = "Apellido Anonimo",
                            ImageReference = "http://localhost/images/R.jpg"
                            //TypeId = 2
                        },
                    });
                    context.SaveChanges();
                }

                //Category
                if(!context.Category.Any()){
                    context.Category.AddRange(new List<Category>(){
                        new Category(){
                            Name = ListCategory.Dice
                        },
                        new Category(){
                            Name = ListCategory.Commission
                        },
                        new Category(){
                            Name = ListCategory.Dice
                        },
                        new Category(){
                            Name = ListCategory.Commission
                        },
                    });
                    context.SaveChanges();
                }

                //CategoryProduct
                if(!context.CategoryProduct.Any()){
                    context.CategoryProduct.AddRange(new List<CategoryProduct>(){
                        new CategoryProduct(){
                            ProductId = 2,
                            CategoryId = 1,
                        },
                        new CategoryProduct(){
                            ProductId = 3,
                            CategoryId = 2,
                        },
                        new CategoryProduct(){
                            ProductId = 4,
                            CategoryId = 3,
                        },
                        new CategoryProduct(){
                            ProductId = 5,
                            CategoryId = 4,
                        },
                    });
                    context.SaveChanges();
                }

                //CategoryCommission
                if(!context.CategoryCommi.Any()){
                    context.CategoryCommi.AddRange(new List<CategoryCommi>(){
                        new CategoryCommi(){
                            CommissionId = 1,
                            CategoryId = 1,
                        },
                        new CategoryCommi(){
                            CommissionId = 2,
                            CategoryId = 2,
                        },
                        new CategoryCommi(){
                            CommissionId = 3,
                            CategoryId = 3,
                        },
                        new CategoryCommi(){
                            CommissionId = 4,
                            CategoryId = 4,
                        },
                    });
                    context.SaveChanges();
                }

                //Banner
                if(!context.Banner.Any()){
                    context.Banner.AddRange(new List<Banner>(){
                        new Banner(){
                            Name = "No Banner Official",
                            Description = "No Banner Official",
                            size = "No Banner Official",
                            image = "http://localhost/images/OIP.jpg",
                            link = "NA",
                            ProviderId = 1
                        },
                    });
                    context.SaveChanges();
                }

                //Document
                if(!context.Document.Any()){
                    context.Document.AddRange(new List<Document>(){
                        new Document(){
                            Name = "Certificado de Autenticidad",
                            Link = "https://i.etsystatic.com/27467434/r/il/c302dd/3084951679/il_fullxfull.3084951679_c7cc.jpg"
                        },
                    });
                    context.SaveChanges();
                }

                //DocProduct
                if(!context.DocProduct.Any()){
                    context.DocProduct.AddRange(new List<DocProduct>(){
                        new DocProduct(){
                            DocumentId = 1,
                            ProductId = 2
                        },
                        new DocProduct(){
                            DocumentId = 1,
                            ProductId = 3
                        },
                        new DocProduct(){
                            DocumentId = 1,
                            ProductId = 4
                        },
                        new DocProduct(){
                            DocumentId = 1,
                            ProductId = 5
                        },
                    });
                    context.SaveChanges();
                }

                //DocCommi
                if(!context.DocCommi.Any()){
                    context.DocCommi.AddRange(new List<DocCommi>(){
                        new DocCommi(){
                            CommissionId = 1,
                            DocId = 1
                        },
                        new DocCommi(){
                            CommissionId = 2,
                            DocId = 1
                        },
                        new DocCommi(){
                            CommissionId = 3,
                            DocId = 1
                        },
                        new DocCommi(){
                            CommissionId = 4,
                            DocId = 1
                        },
                    });
                    context.SaveChanges();
                }
           
           }
        }
    
        public static async Task SeedUserAndRolesAsync(IApplicationBuilder app){
            using (var serviceScope = app.ApplicationServices.CreateScope()){
                var services = serviceScope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDbContext>();
                
                //Roles
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                if(await roleManager.FindByNameAsync(UserRoles.Admin) == null){
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                }
                if(await roleManager.FindByNameAsync(UserRoles.User) == null){
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                }
                if(await roleManager.FindByNameAsync(UserRoles.Provider) == null){
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Provider));
                }
                //Users
                string password = "Ab.1324aBc";
                string email = "theadministrator@gmail.com";
                var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                if(await userManager.FindByEmailAsync(email) == null){
                    var user = new ApplicationUser(){
                        UserName = email,
                        FullName = "Administrator User",
                        Email = email,
                        PhoneNumber = "(+57) 300 333 3333",
                        EmailConfirmed = true
                    };
                    var result = await userManager.CreateAsync(user);
                    if(result.Succeeded){
                        await userManager.AddPasswordAsync(user, password);
                        await userManager.AddToRoleAsync(user, UserRoles.Admin);
                    }
                }

                password = "Ab.1324aBc";
                email = "theaclient@gmail.com";
                //var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                if(await userManager.FindByEmailAsync(email) == null){
                    var user = new ApplicationUser(){
                        UserName = email,
                        FullName = "Client User",
                        Email = email,
                        PhoneNumber = "(+57) 300 333 3333",
                        EmailConfirmed = true
                    };
                    var result = await userManager.CreateAsync(user);
                    if(result.Succeeded){
                        await userManager.AddPasswordAsync(user, password);
                        await userManager.AddToRoleAsync(user, UserRoles.User);
                    }
                }

                password = "Ab.1324aBc";
                email = "theacProvider@gmail.com";
                //var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                if(await userManager.FindByEmailAsync(email) == null){
                    var user = new ApplicationUser(){
                        UserName = email,
                        FullName = "Provider User",
                        Email = email,
                        PhoneNumber = "(+57) 300 333 3333",
                        EmailConfirmed = true
                    };
                    var result = await userManager.CreateAsync(user);
                    if(result.Succeeded){
                        await userManager.AddPasswordAsync(user, password);
                        await userManager.AddToRoleAsync(user, UserRoles.Provider);
                    }
                }

            }
        }

    }
}