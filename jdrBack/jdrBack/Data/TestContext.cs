﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using jdrBack.Models;

namespace jdrBack.Data
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Fight> Fights { get; set; }
        public virtual DbSet<Scene> Scenes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Choice>(entity =>
            {
                entity.ToTable("choice");

                entity.Property(e => e.ChoiceId)
                    .ValueGeneratedNever()
                    .HasColumnName("choice_id");

                entity.Property(e => e.ChoiceText)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("choice_text");

                entity.Property(e => e.ChoiceTextLiaison)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("choice_text_liaison");

                entity.Property(e => e.Condition)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("condition");

                entity.Property(e => e.FightId).HasColumnName("fight_id");

                entity.Property(e => e.LifePoint).HasColumnName("life_point");

                entity.Property(e => e.NextSceneId).HasColumnName("next_scene_id");

                entity.Property(e => e.Rules)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("rules");

                entity.Property(e => e.SceneId).HasColumnName("scene_id");
            });

            modelBuilder.Entity<Fight>(entity =>
            {
                entity.ToTable("fight");

                entity.Property(e => e.FightId)
                    .ValueGeneratedNever()
                    .HasColumnName("fight_id");

                entity.Property(e => e.DeathText)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("death_text");

                entity.Property(e => e.Flee).HasColumnName("flee");

                entity.Property(e => e.Opponent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("opponent");

                entity.Property(e => e.Stamina)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("stamina");

                entity.Property(e => e.Strength)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("strength");

                entity.Property(e => e.VictoryText)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("victory_text");
            });

            modelBuilder.Entity<Scene>(entity =>
            {
                entity.ToTable("scene");

                entity.Property(e => e.SceneId)
                    .ValueGeneratedNever()
                    .HasColumnName("scene_id");

                entity.Property(e => e.Decor)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("decor");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}