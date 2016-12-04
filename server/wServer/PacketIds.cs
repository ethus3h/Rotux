//This file was generated by ossimc82's automatic "Prod-Client to PServer-Client" builder!
namespace wServer
{
    public enum PacketID : byte
    {
       FAILURE = 0, //slotid: 1
       CREATE_SUCCESS = 33, //slotid: 2
       CREATE = 78, //slotid: 3
       PLAYERSHOOT = 13, //slotid: 4
       MOVE = 87, //slotid: 5
       PLAYERTEXT = 39, //slotid: 6
       TEXT = 67, //slotid: 7
       SHOOT2 = 84, //slotid: 8
       DAMAGE = 51, //slotid: 9
       UPDATE = 7, //slotid: 10
       UPDATEACK = 45, //slotid: 11
       NOTIFICATION = 53, //slotid: 12
       NEW_TICK = 80, //slotid: 13
       INVSWAP = 34, //slotid: 14
       USEITEM = 48, //slotid: 15
       SHOW_EFFECT = 28, //slotid: 16
       HELLO = 35, //slotid: 17
       GOTO = 3, //slotid: 18
       INVDROP = 90, //slotid: 19
       INVRESULT = 58, //slotid: 20
       RECONNECT = 21, //slotid: 21
       PING = 46, //slotid: 22
       PONG = 52, //slotid: 23
       MAPINFO = 65, //slotid: 24
       LOAD = 8, //slotid: 25
       PIC = 60, //slotid: 26
       SETCONDITION = 91, //slotid: 27
       TELEPORT = 40, //slotid: 28
       USEPORTAL = 9, //slotid: 29
       DEATH = 63, //slotid: 30
       BUY = 75, //slotid: 31
       BUYRESULT = 10, //slotid: 32
       AOE = 69, //slotid: 33
       GROUNDDAMAGE = 59, //slotid: 34
       PLAYERHIT = 17, //slotid: 35
       ENEMYHIT = 42, //slotid: 36
       AOEACK = 95, //slotid: 37
       SHOOTACK = 36, //slotid: 38
       OTHERHIT = 14, //slotid: 39
       SQUAREHIT = 86, //slotid: 40
       GOTOACK = 12, //slotid: 41
       EDITACCOUNTLIST = 93, //slotid: 42
       ACCOUNTLIST = 20, //slotid: 43
       QUESTOBJID = 77, //slotid: 44
       CHOOSENAME = 82, //slotid: 45
       NAMERESULT = 62, //slotid: 46
       CREATEGUILD = 44, //slotid: 47
       CREATEGUILDRESULT = 4, //slotid: 48
       GUILDREMOVE = 24, //slotid: 49
       GUILDINVITE = 23, //slotid: 50
       ALLYSHOOT = 92, //slotid: 51
       SHOOT = 96, //slotid: 52
       REQUESTTRADE = 41, //slotid: 53
       TRADEREQUESTED = 94, //slotid: 54
       TRADESTART = 64, //slotid: 55
       CHANGETRADE = 1, //slotid: 56
       TRADECHANGED = 56, //slotid: 57
       ACCEPTTRADE = 6, //slotid: 58
       CANCELTRADE = 5, //slotid: 59
       TRADEDONE = 25, //slotid: 60
       TRADEACCEPTED = 22, //slotid: 61
       CLIENTSTAT = 66, //slotid: 62
       CHECKCREDITS = 19, //slotid: 63
       ESCAPE = 47, //slotid: 64
       FILE = 88, //slotid: 65
       INVITEDTOGUILD = 79, //slotid: 66
       JOINGUILD = 61, //slotid: 67
       CHANGEGUILDRANK = 89, //slotid: 68
       PLAYSOUND = 50, //slotid: 69
       GLOBAL_NOTIFICATION = 30, //slotid: 70
       RESKIN = 68, //slotid: 71
       PETYARDCOMMAND = 85, //slotid: 72
       PETCOMMAND = 57, //slotid: 73
       UPDATEPET = 83, //slotid: 74
       NEWABILITYUNLOCKED = 97, //slotid: 75
       UPGRADEPETYARDRESULT = 55, //slotid: 76
       EVOLVEPET = 76, //slotid: 77
       REMOVEPET = 26, //slotid: 78
       HATCHEGG = 81, //slotid: 79
       ENTER_ARENA = 27, //slotid: 80
       ARENANEXTWAVE = 31, //slotid: 81
       ARENADEATH = 15, //slotid: 82
       LEAVEARENA = 49, //slotid: 83
       VERIFYEMAILDIALOG = 98, //slotid: 84
       RESKIN2 = 11, //slotid: 85
       PASSWORDPROMPT = 74, //slotid: 86
       VIEWQUESTS = 16, //slotid: 87
       TINKERQUEST = 38, //slotid: 88
       QUESTFETCHRESPONSE = 37, //slotid: 89
       QUESTREDEEMRESPONSE = 18 //slotid: 90
    }
}