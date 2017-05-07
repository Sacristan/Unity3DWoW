﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public enum PlayerChatTag
    {
        CHAT_TAG_NONE = 0,
        CHAT_TAG_AFK = 1,
        CHAT_TAG_DND = 2,
        CHAT_TAG_GM = 3,
    };

    public enum ChatMsg
    {
        CHAT_MSG_SAY = 0x00,
        CHAT_MSG_PARTY = 0x01,
        CHAT_MSG_RAID = 0x02,
        CHAT_MSG_GUILD = 0x03,
        CHAT_MSG_OFFICER = 0x04,
        CHAT_MSG_YELL = 0x05,
        CHAT_MSG_WHISPER = 0x06,
        CHAT_MSG_WHISPER_INFORM = 0x07,
        CHAT_MSG_EMOTE = 0x08,
        CHAT_MSG_TEXT_EMOTE = 0x09,
        CHAT_MSG_SYSTEM = 0x0A,
        CHAT_MSG_MONSTER_SAY = 0x0B,
        CHAT_MSG_MONSTER_YELL = 0x0C,
        CHAT_MSG_MONSTER_EMOTE = 0x0D,
        CHAT_MSG_CHANNEL = 0x0E,
        CHAT_MSG_CHANNEL_JOIN = 0x0F,
        CHAT_MSG_CHANNEL_LEAVE = 0x10,
        CHAT_MSG_CHANNEL_LIST = 0x11,
        CHAT_MSG_CHANNEL_NOTICE = 0x12,
        CHAT_MSG_CHANNEL_NOTICE_USER = 0x13,
        CHAT_MSG_AFK = 0x14,
        CHAT_MSG_DND = 0x15,
        CHAT_MSG_IGNORED = 0x16,
        CHAT_MSG_SKILL = 0x17,
        CHAT_MSG_LOOT = 0x18,
        CHAT_MSG_MONSTER_WHISPER = 0x1A,
        CHAT_MSG_BG_SYSTEM_NEUTRAL = 0x52,
        CHAT_MSG_BG_SYSTEM_ALLIANCE = 0x53,
        CHAT_MSG_BG_SYSTEM_HORDE = 0x54,
        CHAT_MSG_RAID_LEADER = 0x57,
        CHAT_MSG_RAID_WARNING = 0x58,
        CHAT_MSG_RAID_BOSS_WHISPER = 0x59,
        CHAT_MSG_RAID_BOSS_EMOTE = 0x5A,
        CHAT_MSG_BATTLEGROUND = 0x5C,
        CHAT_MSG_BATTLEGROUND_LEADER = 0x5D,

        // [-ZERO] Need find correct values
        // CHAT_MSG_REPLY                  = 0x09,
        CHAT_MSG_MONSTER_PARTY = 0x30, // 0x0D, just selected some free random value for avoid duplicates with really existed values
                                       // CHAT_MSG_MONEY                  = 0x1C,
                                       // CHAT_MSG_OPENING                = 0x1D,
                                       // CHAT_MSG_TRADESKILLS            = 0x1E,
                                       // CHAT_MSG_PET_INFO               = 0x1F,
                                       // CHAT_MSG_COMBAT_MISC_INFO       = 0x20,
                                       // CHAT_MSG_COMBAT_XP_GAIN         = 0x21,
                                       // CHAT_MSG_COMBAT_HONOR_GAIN      = 0x22,
                                       // CHAT_MSG_COMBAT_FACTION_CHANGE  = 0x23,
                                       // CHAT_MSG_FILTERED               = 0x2B,
                                       // CHAT_MSG_RESTRICTED             = 0x2E,

    };

    public enum Languages
    {
        Universal = 0x00,
        Orcish = 0x01,
        Darnassian = 0x02,
        Taurahe = 0x03,
        Dwarvish = 0x06,
        Common = 0x07,
        Thelessian = 0x0A,
        Gnomish = 0x0D,
        Trollish = 0x0E,
        Gutterspeak = 0x21,
        Draenei = 0x23,
        NUM_LANGUAGES = 0x24
    };

public enum EmoteType : int
{
    AGREE = 1,
    AMAZE,
    ANGRY,
    APOLOGIZE,
    APPLAUD,
    BASHFUL,
    BECKON,
    BEG,
    BITE,
    BLEED,
    BLINK,
    BLUSH,
    BONK,
    BORED,
    BOUNCE,
    BRB,
    BOW,
    BURP,
    BYE,
    CACKLE,
    CHEER,
    CHICKEN,
    CHUCKLE,
    CLAP,
    CONFUSED,
    CONGRATULATE,
    COUGH,
    COWER,
    CRACK,
    CRINGE,
    CRY,
    CURIOUS,
    CURTSEY,
    DANCE,
    DRINK,
    DROOL,
    EAT,
    EYE,
    FART,
    FIDGET,
    FLEX,
    FROWN,
    GASP,
    GAZE,
    GIGGLE,
    GLARE,
    GLOAT,
    GREET,
    GRIN,
    GROAN,
    GROVEL,
    GUFFAW,
    HAIL,
    HAPPY,
    HELLO,
    HUG,
    HUNGRY,
    KISS,
    KNEEL,
    LAUGH,
    LAYDOWN,
    MASSAGE,
    MOAN,
    MOON,
    MOURN,
    NO,
    NOD,
    NOSEPICK,
    PANIC,
    PEER,
    PLEAD,
    POINT,
    POKE,
    PRAY,
    ROAR,
    ROFL,
    RUDE,
    SALUTE,
    SCRATCH,
    SEXY,
    SHAKE,
    SHOUT,
    SHRUG,
    SHY,
    SIGH,
    SIT,
    SLEEP,
    SNARL,
    SPIT,
    STARE,
    SURPRISED,
    SURRENDER,
    TALK,
    TALKEX,
    TALKQ,
    TAP,
    THANK,
    THREATEN,
    TIRED,
    VICTORY,
    WAVE,
    WELCOME,
    WHINE,
    WHISTLE,
    WORK,
    YAWN,
    BOGGLE,
    CALM,
    COLD,
    COMFORT,
    CUDDLE,
    DUCK,
    INSULT,
    INTRODUCE,
    JK,
    LICK,
    LISTEN,
    LOST,
    MOCK,
    PONDER,
    POUNCE,
    PRAISE,
    PURR,
    PUZZLE,
    RAISE,
    READY,
    SHIMMY,
    SHIVER,
    SHOO,
    SLAP,
    SMIRK,
    SNIFF,
    SNUB,
    SOOTHE,
    STINK,
    TAUNT,
    TEASE,
    THIRSTY,
    VETO,
    SNICKER,
    STAND,
    TICKLE,
    VIOLIN,
    SMILE,
    RASP,
    PITY,
    GROWL,
    BARK,
    SCARED,
    FLOP,
    LOVE,
    MOO,
    COMMEND,
    TRAIN,
    HELPME,
    INCOMING,
    CHARGE,
    FLEE,
    ATTACKMYTARGET,
    OOM,
    FOLLOW,
    WAIT,
    HEALME,
    OPENFIRE,
    FLIRT,
    JOKE,
    GOLFCLAP,
    WINK,
    PAT,
    SERIOUS,
    MOUNTSPECIAL,
    GOODLUCK,
    BLAME,
    BLANK,
    BRANDISH,
    BREATH,
    DISAGREE,
    DOUBT,
    EMBARRASS,
    ENCOURAGE,
    ENEMY,
    EYEBROW,
    TOAST,
}