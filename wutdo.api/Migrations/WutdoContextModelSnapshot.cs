﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wutdo.api.Models;

namespace wutdo.api.Migrations
{
    [DbContext(typeof(WutdoContext))]
    partial class WutdoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("wutdo.api.Models.AnswerOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerText");

                    b.Property<int?>("Order");

                    b.Property<int?>("PollId");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("AnswerOption");
                });

            modelBuilder.Entity("wutdo.api.Models.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Question");

                    b.HasKey("Id");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("wutdo.api.Models.AnswerOption", b =>
                {
                    b.HasOne("wutdo.api.Models.Poll", "Poll")
                        .WithMany("AnswerOptions")
                        .HasForeignKey("PollId");
                });
#pragma warning restore 612, 618
        }
    }
}
