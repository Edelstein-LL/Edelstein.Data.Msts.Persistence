using Microsoft.EntityFrameworkCore;

namespace Edelstein.Data.Msts.Persistence;

public class MstDbContext : DbContext
{
    public MstDbContext(DbContextOptions<MstDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AchievementMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<AdjustTrackingListMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<AlbumCardMMst>(entity =>
        {
            entity.HasKey(e => e.CardId);
        });

        modelBuilder.Entity<AlbumMemberTagMMst>(entity =>
        {
            entity.HasKey(e => e.MemberTagId);
        });

        modelBuilder.Entity<AlbumMultiUnitMMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MultiUnitId,
                e.UnitId
            });
        });

        modelBuilder.Entity<AlbumSeriesMMst>(entity =>
        {
            entity.HasKey(e => e.AlbumSeriesId);
        });

        modelBuilder.Entity<AlbumSeriesThumbnailAssetMMst>(entity =>
        {
            entity.HasKey(e => e.AlbumSeriesId);
        });

        modelBuilder.Entity<AlbumUnitMMst>(entity =>
        {
            entity.HasKey(e => e.UnitId);
        });

        modelBuilder.Entity<AlbumUnitPairMMst>(entity =>
        {
            entity.HasKey(e => e.UnitPairId);
        });

        modelBuilder.Entity<AlbumUnitSeriesMMst>(entity =>
        {
            entity.HasKey(e => e.AlbumUnitSeriesId);
        });

        modelBuilder.Entity<AlbumUnitTypeMemberTagMMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.UnitTypeId,
                e.MemberTagId
            });
        });

        modelBuilder.Entity<AlbumUnitTypeMst>(entity =>
        {
            entity.HasKey(e => e.UnitTypeId);
        });

        modelBuilder.Entity<BeginnerMissionMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number,
                e.Level
            });
        });

        modelBuilder.Entity<BeginnerMissionRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<BeginnerMissionRewardSettingMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterBeginnerMissionId,
                e.Level,
                e.Number
            });
        });

        modelBuilder.Entity<BgmMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<BillingProductMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<BillingProductRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<BillingShopMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<BillingSubscriptionMst>(entity =>
        {
            entity.HasKey(e => e.MasterBillingProductId);
        });

        modelBuilder.Entity<BillingSubscriptionRewardMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterBillingSubscriptionLabel,
                e.Number
            });
        });

        modelBuilder.Entity<CardCollectionRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<CardEvolveConditionMst>(entity =>
        {
            entity.HasKey(e => e.MasterCardId);
        });

        modelBuilder.Entity<CardEvolveMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Rarity,
                e.EvolveCount
            });
        });

        modelBuilder.Entity<CardGetMst>(entity =>
        {
            entity.HasKey(e => e.MasterCardId);
        });

        modelBuilder.Entity<CardLevelMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Level
            });
        });

        modelBuilder.Entity<CardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<CardRarityMst>(entity =>
        {
            entity.HasKey(e => e.Rarity);
        });

        modelBuilder.Entity<CardSkillLevelMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Level
            });
        });

        modelBuilder.Entity<CardSysVoiceMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.MasterVoiceId
            });
        });

        modelBuilder.Entity<CharacterGroupMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.CharacterId,
                e.GroupId
            });
        });

        modelBuilder.Entity<CharacterMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<CharacterSysVoiceMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.MasterCharacterId,
                e.MasterVoiceId
            });
        });

        modelBuilder.Entity<ChatAttachmentMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ChatChapterMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ChatCharacterMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ChatMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ChatRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ChatRoomMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ChatStampMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ChatVoiceKeyMst>(entity =>
        {
            entity.HasKey(e => e.Key);
        });

        modelBuilder.Entity<ChipsterResultCodeMst>(entity =>
        {
            entity.HasKey(e => e.ResultCode);
        });

        modelBuilder.Entity<ComicMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<CommonBgMovieMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ConstMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<DateConditionMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<DateConditionOthersMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Num
            });
        });

        modelBuilder.Entity<DialogButtonMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<DialogMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<EventCardBonusMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.TargetId
            });
        });

        modelBuilder.Entity<EventLiveMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.MasterLiveId
            });
        });

        modelBuilder.Entity<EventMemberRankingMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.GroupId,
                e.Number
            });
        });

        modelBuilder.Entity<EventMemberRankingRewardMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number
            });
        });

        modelBuilder.Entity<EventMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<EventPointMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.Number
            });
        });

        modelBuilder.Entity<EventPointRankingMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.GroupId,
                e.Number
            });
        });

        modelBuilder.Entity<EventPointRankingRewardMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number
            });
        });

        modelBuilder.Entity<EventPointRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<EventPointSettingsMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<EventScoreMst>(entity =>
        {
            entity.HasKey(e => e.MasterEventId);
        });

        modelBuilder.Entity<EventScoreRankingMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.Number
            });
        });

        modelBuilder.Entity<EventScoreRankingRewardMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number
            });
        });

        modelBuilder.Entity<EventStoryMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.MasterStoryId
            });
        });

        modelBuilder.Entity<EventTipsMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.RootPath
            });
        });

        modelBuilder.Entity<EventTipsPageMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.SpriteName
            });
        });

        modelBuilder.Entity<EventTopBannerMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.MasterGachaId
            });
        });

        modelBuilder.Entity<EventTypeMst>(entity =>
        {
            entity.HasKey(e => e.EventLiveName);
        });

        modelBuilder.Entity<EvolveItemAmountMst>(entity =>
        {
            entity.HasKey(e => e.Rarity);
        });

        modelBuilder.Entity<EvolveItemConditionMst>(entity =>
        {
            entity.HasKey(e => e.MasterItemId);
        });

        modelBuilder.Entity<ExchangeItemMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ExchangeItemRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ExchangeMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<FunctionLockMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<GamelibResultCodeMst>(entity =>
        {
            entity.HasKey(e => e.ResultCode);
        });

        modelBuilder.Entity<GroupMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<HomeBannerMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<HomeBgMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ItemMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LimitedLiveMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveBoostMst>(entity =>
        {
            entity.HasKey(e => e.Value);
        });

        modelBuilder.Entity<LiveClearRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveComboMst>(entity =>
        {
            entity.HasKey(e => e.ComboNum);
        });

        modelBuilder.Entity<LiveConditionMst>(entity =>
        {
            entity.HasKey(e => e.MasterLiveId);
        });

        modelBuilder.Entity<LiveEffectValueMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveInputResultMst>(entity =>
        {
            entity.HasKey(e => e.Type);
        });

        modelBuilder.Entity<LiveLaneSkinMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveMissionComboMst>(entity =>
        {
            entity.HasKey(e => e.MasterMusicId);
        });

        modelBuilder.Entity<LiveMissionMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveMissionRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveRankingRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveRecommendListMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterLiveRecommendId,
                e.Number
            });
        });

        modelBuilder.Entity<LiveRecommendMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveRewardSettingMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.LiveMode,
                e.ScoreRank
            });
        });

        modelBuilder.Entity<LiveRuleMst>(entity =>
        {
            entity.HasKey(e => e.MasterLiveId);
        });

        modelBuilder.Entity<LiveTapEffectMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LiveTapSeMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LocationMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LocationRewardMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number
            });
        });

        modelBuilder.Entity<LoginBonusMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LoginBonusRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LoginBonusRewardSettingMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterLoginBonusId,
                e.DayCount
            });
        });

        modelBuilder.Entity<LotteryCautionMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LotteryEffMovieMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.BandCategory
            });
        });

        modelBuilder.Entity<LotteryEffMovieRatioMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LotteryImageMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LotteryInfoMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LotteryItemMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number
            });
            entity.HasIndex(e => e.Id);
        });

        modelBuilder.Entity<LotteryMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LotteryPriceMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number
            });
        });

        modelBuilder.Entity<LotteryRarityMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number
            });
            entity.HasIndex(e => e.Id);
            entity.HasIndex(e => e.MasterLotteryItemId);
        });

        modelBuilder.Entity<LotteryRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<LotteryStepupMst>(entity =>
        {
            entity.HasKey(e => e.MasterLotteryId);
        });

        modelBuilder.Entity<MembershipWallpaperMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<MissionBannerMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<MissionMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<MissionRewardMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number
            });
        });

        modelBuilder.Entity<MovieKeyMst>(entity =>
        {
            entity.HasKey(e => e.Key);
        });

        modelBuilder.Entity<MovieMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<MultiDailyDropEffectMst>(entity =>
        {
            entity.HasKey(e => e.Name);
        });

        modelBuilder.Entity<MultieventCardBonusMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.TargetId
            });
        });

        modelBuilder.Entity<MultieventMatchingrangeMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<MultieventPenaltyMst>(entity =>
        {
            entity.HasKey(e => e.PenaltyCount);
        });

        modelBuilder.Entity<MultieventRankbonusMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.PlayerCount,
                e.LiveRank,
                e.EventPtBonus
            });
        });

        modelBuilder.Entity<MultieventSettingMst>(entity =>
        {
            entity.HasKey(e => e.EventId);
        });

        modelBuilder.Entity<MultiPenaltyMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<MultiRoomConditionMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<MultiRoomSelectMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<MusicLevelMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterMusicId,
                e.Level
            });
            entity.HasIndex(e => e.MasterMusicId);
        });

        modelBuilder.Entity<MusicMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<MusicShopPriceMst>(entity =>
        {
            entity.HasKey(e => e.MasterMusicId);
        });

        modelBuilder.Entity<NavigationConditionMst>(entity =>
        {
            entity.HasKey(e => e.MasterNavigationId);
        });

        modelBuilder.Entity<NavigationDialogPageMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterNavigationId,
                e.SpriteName
            });
        });

        modelBuilder.Entity<NavigationMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<NewSkillMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<NoticeBirthdayMst>(entity =>
        {
            entity.HasKey(e => e.MasterNoticeGeneralId);
        });

        modelBuilder.Entity<NoticeCardImageMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<NoticeCardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<NoticeGachaMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<NoticeGeneralMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<NoticeGeneralNavigationMst>(entity =>
        {
            entity.HasKey(e => e.MasterNoticeGeneralId);
        });

        modelBuilder.Entity<NoticeGeneralSequenceMst>(entity =>
        {
            entity.HasKey(e => e.MasterNoticeGeneralId);
        });

        modelBuilder.Entity<NoticeMusicImageMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<NoticeMusicMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<PartVoiceKeyMst>(entity =>
        {
            entity.HasKey(e => e.Key);
        });

        modelBuilder.Entity<PresetBackgroundMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<PresetForegroundMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ReleaseLabelMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ResourceDownloadMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ResultCodeMst>(entity =>
        {
            entity.HasKey(e => e.ResultCode);
        });

        modelBuilder.Entity<RhythmIconMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<SceneTitleMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<SeMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ShopItemMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<ShopRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<SkillCenterEffectMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<SkillCenterMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<SoundKeyMst>(entity =>
        {
            entity.HasKey(e => e.Key);
        });

        modelBuilder.Entity<StampMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<StarEventCardBonusMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.MasterEventId,
                e.TargetId
            });
        });

        modelBuilder.Entity<StarEventLevelMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Level
            });
        });

        modelBuilder.Entity<StarEventLevelRewardMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number
            });
        });

        modelBuilder.Entity<StarEventLevelRewardSettingMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Level
            });
        });

        modelBuilder.Entity<StarEventSettingMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.StarId
            });
        });

        modelBuilder.Entity<StoryMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<StoryPartMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<StoryReleaseMst>(entity =>
        {
            entity.HasKey(e => e.MasterStoryPartId);
        });

        modelBuilder.Entity<StoryRewardMst>(entity =>
        {
            entity.HasKey(e => new
            {
                e.Id,
                e.Number
            });
        });

        modelBuilder.Entity<SubscriptionImageMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<SysVoiceKeyMst>(entity =>
        {
            entity.HasKey(e => e.Key);
        });

        modelBuilder.Entity<TextMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<TitleMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<TitleScreenMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<UrlMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<UserRankMst>(entity =>
        {
            entity.HasKey(e => e.Rank);
            entity.HasIndex(e => e.Exp);
        });

        modelBuilder.Entity<UserRankRewardMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<VoiceKeyMst>(entity =>
        {
            entity.HasKey(e => e.Key);
        });

        modelBuilder.Entity<VoiceMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<WipeMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<WipePlayListMst>(entity =>
        {
            entity.HasKey(e => e.Id);
        });
    }

    public DbSet<AchievementMst> AchievementMsts { get; set; }
    public DbSet<AdjustTrackingListMst> AdjustTrackingListMsts { get; set; }
    public DbSet<AlbumCardMMst> AlbumCardMMsts { get; set; }
    public DbSet<AlbumMemberTagMMst> AlbumMemberTagMMsts { get; set; }
    public DbSet<AlbumMultiUnitMMst> AlbumMultiUnitMMsts { get; set; }
    public DbSet<AlbumSeriesMMst> AlbumSeriesMMsts { get; set; }
    public DbSet<AlbumSeriesThumbnailAssetMMst> AlbumSeriesThumbnailAssetMMsts { get; set; }
    public DbSet<AlbumUnitMMst> AlbumUnitMMsts { get; set; }
    public DbSet<AlbumUnitPairMMst> AlbumUnitPairMMsts { get; set; }
    public DbSet<AlbumUnitSeriesMMst> AlbumUnitSeriesMMsts { get; set; }
    public DbSet<AlbumUnitTypeMemberTagMMst> AlbumUnitTypeMemberTagMMsts { get; set; }
    public DbSet<AlbumUnitTypeMst> AlbumUnitTypeMsts { get; set; }
    public DbSet<BeginnerMissionMst> BeginnerMissionMsts { get; set; }
    public DbSet<BeginnerMissionRewardMst> BeginnerMissionRewardMsts { get; set; }
    public DbSet<BeginnerMissionRewardSettingMst> BeginnerMissionRewardSettingMsts { get; set; }
    public DbSet<BgmMst> BgmMsts { get; set; }
    public DbSet<BillingProductMst> BillingProductMsts { get; set; }
    public DbSet<BillingProductRewardMst> BillingProductRewardMsts { get; set; }
    public DbSet<BillingShopMst> BillingShopMsts { get; set; }
    public DbSet<BillingSubscriptionMst> BillingSubscriptionMsts { get; set; }
    public DbSet<BillingSubscriptionRewardMst> BillingSubscriptionRewardMsts { get; set; }
    public DbSet<CardCollectionRewardMst> CardCollectionRewardMsts { get; set; }
    public DbSet<CardEvolveConditionMst> CardEvolveConditionMsts { get; set; }
    public DbSet<CardEvolveMst> CardEvolveMsts { get; set; }
    public DbSet<CardGetMst> CardGetMsts { get; set; }
    public DbSet<CardLevelMst> CardLevelMsts { get; set; }
    public DbSet<CardMst> CardMsts { get; set; }
    public DbSet<CardRarityMst> CardRarityMsts { get; set; }
    public DbSet<CardSkillLevelMst> CardSkillLevelMsts { get; set; }
    public DbSet<CardSysVoiceMst> CardSysVoiceMsts { get; set; }
    public DbSet<CharacterGroupMst> CharacterGroupMsts { get; set; }
    public DbSet<CharacterMst> CharacterMsts { get; set; }
    public DbSet<CharacterSysVoiceMst> CharacterSysVoiceMsts { get; set; }
    public DbSet<ChatAttachmentMst> ChatAttachmentMsts { get; set; }
    public DbSet<ChatChapterMst> ChatChapterMsts { get; set; }
    public DbSet<ChatCharacterMst> ChatCharacterMsts { get; set; }
    public DbSet<ChatMst> ChatMsts { get; set; }
    public DbSet<ChatRewardMst> ChatRewardMsts { get; set; }
    public DbSet<ChatRoomMst> ChatRoomMsts { get; set; }
    public DbSet<ChatStampMst> ChatStampMsts { get; set; }
    public DbSet<ChatVoiceKeyMst> ChatVoiceKeyMsts { get; set; }
    public DbSet<ChipsterResultCodeMst> ChipsterResultCodeMsts { get; set; }
    public DbSet<ComicMst> ComicMsts { get; set; }
    public DbSet<CommonBgMovieMst> CommonBgMovieMsts { get; set; }
    public DbSet<ConstMst> ConstMsts { get; set; }
    public DbSet<DateConditionMst> DateConditionMsts { get; set; }
    public DbSet<DateConditionOthersMst> DateConditionOthersMsts { get; set; }
    public DbSet<DialogButtonMst> DialogButtonMsts { get; set; }
    public DbSet<DialogMst> DialogMsts { get; set; }
    public DbSet<EventCardBonusMst> EventCardBonusMsts { get; set; }
    public DbSet<EventLiveMst> EventLiveMsts { get; set; }
    public DbSet<EventMemberRankingMst> EventMemberRankingMsts { get; set; }
    public DbSet<EventMemberRankingRewardMst> EventMemberRankingRewardMsts { get; set; }
    public DbSet<EventMst> EventMsts { get; set; }
    public DbSet<EventPointMst> EventPointMsts { get; set; }
    public DbSet<EventPointRankingMst> EventPointRankingMsts { get; set; }
    public DbSet<EventPointRankingRewardMst> EventPointRankingRewardMsts { get; set; }
    public DbSet<EventPointRewardMst> EventPointRewardMsts { get; set; }
    public DbSet<EventPointSettingsMst> EventPointSettingsMsts { get; set; }
    public DbSet<EventScoreMst> EventScoreMsts { get; set; }
    public DbSet<EventScoreRankingMst> EventScoreRankingMsts { get; set; }
    public DbSet<EventScoreRankingRewardMst> EventScoreRankingRewardMsts { get; set; }
    public DbSet<EventStoryMst> EventStoryMsts { get; set; }
    public DbSet<EventTipsMst> EventTipsMsts { get; set; }
    public DbSet<EventTipsPageMst> EventTipsPageMsts { get; set; }
    public DbSet<EventTopBannerMst> EventTopBannerMsts { get; set; }
    public DbSet<EventTypeMst> EventTypeMsts { get; set; }
    public DbSet<EvolveItemAmountMst> EvolveItemAmountMsts { get; set; }
    public DbSet<EvolveItemConditionMst> EvolveItemConditionMsts { get; set; }
    public DbSet<ExchangeItemMst> ExchangeItemMsts { get; set; }
    public DbSet<ExchangeItemRewardMst> ExchangeItemRewardMsts { get; set; }
    public DbSet<ExchangeMst> ExchangeMsts { get; set; }
    public DbSet<FunctionLockMst> FunctionLockMsts { get; set; }
    public DbSet<GamelibResultCodeMst> GamelibResultCodeMsts { get; set; }
    public DbSet<GroupMst> GroupMsts { get; set; }
    public DbSet<HomeBannerMst> HomeBannerMsts { get; set; }
    public DbSet<HomeBgMst> HomeBgMsts { get; set; }
    public DbSet<ItemMst> ItemMsts { get; set; }
    public DbSet<LimitedLiveMst> LimitedLiveMsts { get; set; }
    public DbSet<LiveBoostMst> LiveBoostMsts { get; set; }
    public DbSet<LiveClearRewardMst> LiveClearRewardMsts { get; set; }
    public DbSet<LiveComboMst> LiveComboMsts { get; set; }
    public DbSet<LiveConditionMst> LiveConditionMsts { get; set; }
    public DbSet<LiveEffectValueMst> LiveEffectValueMsts { get; set; }
    public DbSet<LiveInputResultMst> LiveInputResultMsts { get; set; }
    public DbSet<LiveLaneSkinMst> LiveLaneSkinMsts { get; set; }
    public DbSet<LiveMissionComboMst> LiveMissionComboMsts { get; set; }
    public DbSet<LiveMissionMst> LiveMissionMsts { get; set; }
    public DbSet<LiveMissionRewardMst> LiveMissionRewardMsts { get; set; }
    public DbSet<LiveMst> LiveMsts { get; set; }
    public DbSet<LiveRankingRewardMst> LiveRankingRewardMsts { get; set; }
    public DbSet<LiveRecommendListMst> LiveRecommendListMsts { get; set; }
    public DbSet<LiveRecommendMst> LiveRecommendMsts { get; set; }
    public DbSet<LiveRewardMst> LiveRewardMsts { get; set; }
    public DbSet<LiveRewardSettingMst> LiveRewardSettingMsts { get; set; }
    public DbSet<LiveRuleMst> LiveRuleMsts { get; set; }
    public DbSet<LiveTapEffectMst> LiveTapEffectMsts { get; set; }
    public DbSet<LiveTapSeMst> LiveTapSeMsts { get; set; }
    public DbSet<LocationMst> LocationMsts { get; set; }
    public DbSet<LocationRewardMst> LocationRewardMsts { get; set; }
    public DbSet<LoginBonusMst> LoginBonusMsts { get; set; }
    public DbSet<LoginBonusRewardMst> LoginBonusRewardMsts { get; set; }
    public DbSet<LoginBonusRewardSettingMst> LoginBonusRewardSettingMsts { get; set; }
    public DbSet<LotteryCautionMst> LotteryCautionMsts { get; set; }
    public DbSet<LotteryEffMovieMst> LotteryEffMovieMsts { get; set; }
    public DbSet<LotteryEffMovieRatioMst> LotteryEffMovieRatioMsts { get; set; }
    public DbSet<LotteryImageMst> LotteryImageMsts { get; set; }
    public DbSet<LotteryInfoMst> LotteryInfoMsts { get; set; }
    public DbSet<LotteryItemMst> LotteryItemMsts { get; set; }
    public DbSet<LotteryMst> LotteryMsts { get; set; }
    public DbSet<LotteryPriceMst> LotteryPriceMsts { get; set; }
    public DbSet<LotteryRarityMst> LotteryRarityMsts { get; set; }
    public DbSet<LotteryRewardMst> LotteryRewardMsts { get; set; }
    public DbSet<LotteryStepupMst> LotteryStepupMsts { get; set; }
    public DbSet<MembershipWallpaperMst> MembershipWallpaperMsts { get; set; }
    public DbSet<MissionBannerMst> MissionBannerMsts { get; set; }
    public DbSet<MissionMst> MissionMsts { get; set; }
    public DbSet<MissionRewardMst> MissionRewardMsts { get; set; }
    public DbSet<MovieKeyMst> MovieKeyMsts { get; set; }
    public DbSet<MovieMst> MovieMsts { get; set; }
    public DbSet<MultiDailyDropEffectMst> MultiDailyDropEffectMsts { get; set; }
    public DbSet<MultieventCardBonusMst> MultieventCardBonusMsts { get; set; }
    public DbSet<MultieventMatchingrangeMst> MultieventMatchingrangeMsts { get; set; }
    public DbSet<MultieventPenaltyMst> MultieventPenaltyMsts { get; set; }
    public DbSet<MultieventRankbonusMst> MultieventRankbonusMsts { get; set; }
    public DbSet<MultieventSettingMst> MultieventSettingMsts { get; set; }
    public DbSet<MultiPenaltyMst> MultiPenaltyMsts { get; set; }
    public DbSet<MultiRoomConditionMst> MultiRoomConditionMsts { get; set; }
    public DbSet<MultiRoomSelectMst> MultiRoomSelectMsts { get; set; }
    public DbSet<MusicLevelMst> MusicLevelMsts { get; set; }
    public DbSet<MusicMst> MusicMsts { get; set; }
    public DbSet<MusicShopPriceMst> MusicShopPriceMsts { get; set; }
    public DbSet<NavigationConditionMst> NavigationConditionMsts { get; set; }
    public DbSet<NavigationDialogPageMst> NavigationDialogPageMsts { get; set; }
    public DbSet<NavigationMst> NavigationMsts { get; set; }
    public DbSet<NewSkillMst> NewSkillMsts { get; set; }
    public DbSet<NoticeBirthdayMst> NoticeBirthdayMsts { get; set; }
    public DbSet<NoticeCardImageMst> NoticeCardImageMsts { get; set; }
    public DbSet<NoticeCardMst> NoticeCardMsts { get; set; }
    public DbSet<NoticeGachaMst> NoticeGachaMsts { get; set; }
    public DbSet<NoticeGeneralMst> NoticeGeneralMsts { get; set; }
    public DbSet<NoticeGeneralNavigationMst> NoticeGeneralNavigationMsts { get; set; }
    public DbSet<NoticeGeneralSequenceMst> NoticeGeneralSequenceMsts { get; set; }
    public DbSet<NoticeMusicImageMst> NoticeMusicImageMsts { get; set; }
    public DbSet<NoticeMusicMst> NoticeMusicMsts { get; set; }
    public DbSet<PartVoiceKeyMst> PartVoiceKeyMsts { get; set; }
    public DbSet<PresetBackgroundMst> PresetBackgroundMsts { get; set; }
    public DbSet<PresetForegroundMst> PresetForegroundMsts { get; set; }
    public DbSet<ReleaseLabelMst> ReleaseLabelMsts { get; set; }
    public DbSet<ResourceDownloadMst> ResourceDownloadMsts { get; set; }
    public DbSet<ResultCodeMst> ResultCodeMsts { get; set; }
    public DbSet<RhythmIconMst> RhythmIconMsts { get; set; }
    public DbSet<SceneTitleMst> SceneTitleMsts { get; set; }
    public DbSet<SeMst> SeMsts { get; set; }
    public DbSet<ShopItemMst> ShopItemMsts { get; set; }
    public DbSet<ShopRewardMst> ShopRewardMsts { get; set; }
    public DbSet<SkillCenterEffectMst> SkillCenterEffectMsts { get; set; }
    public DbSet<SkillCenterMst> SkillCenterMsts { get; set; }
    public DbSet<SoundKeyMst> SoundKeyMsts { get; set; }
    public DbSet<StampMst> StampMsts { get; set; }
    public DbSet<StarEventCardBonusMst> StarEventCardBonusMsts { get; set; }
    public DbSet<StarEventLevelMst> StarEventLevelMsts { get; set; }
    public DbSet<StarEventLevelRewardMst> StarEventLevelRewardMsts { get; set; }
    public DbSet<StarEventLevelRewardSettingMst> StarEventLevelRewardSettingMsts { get; set; }
    public DbSet<StarEventSettingMst> StarEventSettingMsts { get; set; }
    public DbSet<StoryMst> StoryMsts { get; set; }
    public DbSet<StoryPartMst> StoryPartMsts { get; set; }
    public DbSet<StoryReleaseMst> StoryReleaseMsts { get; set; }
    public DbSet<StoryRewardMst> StoryRewardMsts { get; set; }
    public DbSet<SubscriptionImageMst> SubscriptionImageMsts { get; set; }
    public DbSet<SysVoiceKeyMst> SysVoiceKeyMsts { get; set; }
    public DbSet<TextMst> TextMsts { get; set; }
    public DbSet<TitleMst> TitleMsts { get; set; }
    public DbSet<TitleScreenMst> TitleScreenMsts { get; set; }
    public DbSet<UrlMst> UrlMsts { get; set; }
    public DbSet<UserRankMst> UserRankMsts { get; set; }
    public DbSet<UserRankRewardMst> UserRankRewardMsts { get; set; }
    public DbSet<VoiceKeyMst> VoiceKeyMsts { get; set; }
    public DbSet<VoiceMst> VoiceMsts { get; set; }
    public DbSet<WipeMst> WipeMsts { get; set; }
    public DbSet<WipePlayListMst> WipePlayListMsts { get; set; }
}
