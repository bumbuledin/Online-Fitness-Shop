﻿// <auto-generated />
using System;
using ClassLibrarySeminarski.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassLibrarySeminarski.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Dobavljac", b =>
                {
                    b.Property<int>("DobavljacID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DobavljacKategorijaID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Obrisan")
                        .HasColumnType("bit");

                    b.HasKey("DobavljacID");

                    b.HasIndex("DobavljacKategorijaID");

                    b.HasIndex("GradID");

                    b.ToTable("Dobavljac");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.DobavljacKategorije", b =>
                {
                    b.Property<int>("DobavljacKategorijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nazivKategorije")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DobavljacKategorijaID");

                    b.ToTable("DobavljacKategorije");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Dodatak", b =>
                {
                    b.Property<int>("DodatakID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("Namjena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Obrisan")
                        .HasColumnType("bit");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.Property<string>("TipDodatka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DodatakID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("Dodatak");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KantonID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostanskiBroj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.HasIndex("KantonID");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Kanton", b =>
                {
                    b.Property<int>("KantonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oznaka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KantonID");

                    b.ToTable("Kantoni");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.KomentarProizvod", b =>
                {
                    b.Property<int>("KomentarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumKomentarisanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KomentarID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("KomentarProizvod");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Aktiviran")
                        .HasColumnType("bit");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KorisnikNalogID")
                        .HasColumnType("int");

                    b.Property<bool>("Obrisan")
                        .HasColumnType("bit");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnikID");

                    b.HasIndex("GradID");

                    b.HasIndex("KorisnikNalogID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.KorisnikKartice", b =>
                {
                    b.Property<int>("KarticaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivna")
                        .HasColumnType("bit");

                    b.Property<string>("BrojKartice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("GodinaIsteka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("MjesecIsteka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazivKartice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KarticaID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("KorisnikKartice");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.KorisnikNalog", b =>
                {
                    b.Property<int>("KorisnikNalogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Obrisan")
                        .HasColumnType("bit");

                    b.Property<int>("VrstaKorisnikaID")
                        .HasColumnType("int");

                    b.HasKey("KorisnikNalogID");

                    b.HasIndex("VrstaKorisnikaID");

                    b.ToTable("KorisnikNalog");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Narudzba", b =>
                {
                    b.Property<int>("NarudzbaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumKreiranjaNarudjbe")
                        .HasColumnType("datetime2");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<bool>("Izbrisano")
                        .HasColumnType("bit");

                    b.Property<float>("IznosBezPDV")
                        .HasColumnType("real");

                    b.Property<float>("IznosSaPDV")
                        .HasColumnType("real");

                    b.Property<int?>("KarticaID")
                        .HasColumnType("int");

                    b.Property<string>("Komentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<bool>("PotvrdaEmail")
                        .HasColumnType("bit");

                    b.Property<int>("StatusNarudzbeID")
                        .HasColumnType("int");

                    b.HasKey("NarudzbaID");

                    b.HasIndex("GradID");

                    b.HasIndex("KarticaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("StatusNarudzbeID");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.NarudzbaStavke", b =>
                {
                    b.Property<int>("NarudzbaStavkeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CijenaStavke")
                        .HasColumnType("real");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbaID")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.Property<string>("Velicina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VrstaProizvoda")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NarudzbaStavkeID");

                    b.HasIndex("NarudzbaID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("NarudzbaStavke");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Obuca", b =>
                {
                    b.Property<int>("ObucaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brend")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Namjena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Obrisan")
                        .HasColumnType("bit");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObucaID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("Obuca");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.ObucaVelicine", b =>
                {
                    b.Property<int>("ObucaVelicinaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ObucaID")
                        .HasColumnType("int");

                    b.Property<string>("Velicina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kolicina")
                        .HasColumnType("int");

                    b.HasKey("ObucaVelicinaID");

                    b.HasIndex("ObucaID");

                    b.ToTable("ObucaVelicine");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Odjeca", b =>
                {
                    b.Property<int>("OdjecaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brend")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Materijal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Obrisan")
                        .HasColumnType("bit");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OdjecaID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("Odjeca");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.OdjecaVelicine", b =>
                {
                    b.Property<int>("OdjecaVelicinaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OdjecaID")
                        .HasColumnType("int");

                    b.Property<string>("Velicina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kolicina")
                        .HasColumnType("int");

                    b.HasKey("OdjecaVelicinaID");

                    b.HasIndex("OdjecaID");

                    b.ToTable("OdjecaVelicine");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Proizvod", b =>
                {
                    b.Property<int>("ProizvodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<int>("DobavljacID")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Obrisan")
                        .HasColumnType("bit");

                    b.Property<DateTime>("datumDodavanja")
                        .HasColumnType("datetime2");

                    b.HasKey("ProizvodID");

                    b.HasIndex("DobavljacID");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.StatusNarudzbe", b =>
                {
                    b.Property<int>("StatusNarudzbeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OpisStanja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusNarudzbeID");

                    b.ToTable("StatusNarudzbe");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Suplementacija", b =>
                {
                    b.Property<int>("SuplementacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brend")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<bool>("Obrisan")
                        .HasColumnType("bit");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.Property<DateTime>("RokTrajanja")
                        .HasColumnType("datetime2");

                    b.Property<float>("Tezina")
                        .HasColumnType("real");

                    b.Property<string>("Uputstvo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kolicina")
                        .HasColumnType("int");

                    b.HasKey("SuplementacijaID");

                    b.HasIndex("KategorijaID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("Suplementacija");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.SuplementacijaKategorije", b =>
                {
                    b.Property<int>("SuplementacijaKategorijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SuplementacijaKategorijaNaziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SuplementacijaKategorijaID");

                    b.ToTable("SuplementacijaKategorije");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Transakcije", b =>
                {
                    b.Property<int>("TransakcijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumTransakcije")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Izbrisano")
                        .HasColumnType("bit");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<float>("NaplaceniIznos")
                        .HasColumnType("real");

                    b.Property<float>("NaplaceniIznosSaPDV")
                        .HasColumnType("real");

                    b.Property<int>("NarudzbaID")
                        .HasColumnType("int");

                    b.HasKey("TransakcijaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("NarudzbaID");

                    b.ToTable("Transakcija");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.VrstaKorisnika", b =>
                {
                    b.Property<int>("VrstaKorisnikaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VrstaNaziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VrstaKorisnikaID");

                    b.ToTable("VrstaKorisnika");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Dobavljac", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.DobavljacKategorije", "DobavljacKategorija")
                        .WithMany()
                        .HasForeignKey("DobavljacKategorijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrarySeminarski.Model.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Dodatak", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Grad", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Kanton", "Kanton")
                        .WithMany()
                        .HasForeignKey("KantonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.KomentarProizvod", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrarySeminarski.Model.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Korisnik", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrarySeminarski.Model.KorisnikNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnikNalogID");
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.KorisnikKartice", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.KorisnikNalog", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.VrstaKorisnika", "VrstaKorisnika")
                        .WithMany()
                        .HasForeignKey("VrstaKorisnikaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Narudzba", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrarySeminarski.Model.KorisnikKartice", "Kartica")
                        .WithMany()
                        .HasForeignKey("KarticaID");

                    b.HasOne("ClassLibrarySeminarski.Model.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrarySeminarski.Model.StatusNarudzbe", "StatusNarudzbe")
                        .WithMany()
                        .HasForeignKey("StatusNarudzbeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.NarudzbaStavke", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Narudzba", "Narudzba")
                        .WithMany()
                        .HasForeignKey("NarudzbaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrarySeminarski.Model.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Obuca", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.ObucaVelicine", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Obuca", "Obuca")
                        .WithMany()
                        .HasForeignKey("ObucaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Odjeca", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.OdjecaVelicine", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Odjeca", "Odjeca")
                        .WithMany()
                        .HasForeignKey("OdjecaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Proizvod", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Dobavljac", "Dobavljac")
                        .WithMany()
                        .HasForeignKey("DobavljacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Suplementacija", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.SuplementacijaKategorije", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrarySeminarski.Model.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibrarySeminarski.Model.Transakcije", b =>
                {
                    b.HasOne("ClassLibrarySeminarski.Model.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrarySeminarski.Model.Narudzba", "Narudzba")
                        .WithMany()
                        .HasForeignKey("NarudzbaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
