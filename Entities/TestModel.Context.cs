﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Shop1.Entities
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class Shop_JVEntities : DbContext
{
    public Shop_JVEntities()
        : base("name=Shop_JVEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Admission> Admissions { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Booking_condition> Booking_condition { get; set; }

    public virtual DbSet<Books_Catalog> Books_Catalog { get; set; }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Pub_houses> Pub_houses { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

}

}

