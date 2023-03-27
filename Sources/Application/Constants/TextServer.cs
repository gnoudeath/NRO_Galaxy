﻿using System.Collections.Generic;

namespace NRO_Server.Application.Constants
{
    public class TextServer
    {
        private static TextServer Instance;

        public static TextServer gI()
        {
            if (Instance == null)
            {
                Instance = new TextServer();
            }
            return Instance;
        }
        public readonly string EMPTY = "";
        public readonly string LOCALHOST = "localhost";
        public readonly int PORT_SQL = 3306;
        public readonly string ROOT_PART = "C:\\";
        public readonly string ROOT_SQL = "root";
        public readonly string DATABASE_DEFAULT = "database";
        public readonly int PORT_DEFAULT = 14445;
        public readonly byte VERSION_DEFAULT = 1;
        public readonly long _10MINUTES = 600000L;
        public readonly long _1MINUTES = 60000L;
        public readonly string ERROR_SERVER = "Lỗi server, vui lòng thử lại sau";
        public readonly string UPDATING = "Chức năng này đang được cập nhật";
        public readonly string MAINTENANCE = "Hệ thống sẽ bảo trì sau {0} phút nữa, vui lòng thoát game";
        public readonly string ERROR_ADMIN = "Có lỗi xảy ra, vui lòng liên hệ ADMIN để biết thêm chi tiết";
        public readonly string LOCK_LOGIN = "Vui lòng đăng ký tài khoản tại Key Vàng box Zalo NRO Galaxy để vào game";
        public readonly string NOT_ACTIVE = "Tài khoản của bạn chưa được kích hoạt\nTruy cập NRO Galaxy để kích hoạt tài khoản với phí chỉ 20k VNĐ bằng cách nạp card.";
        public readonly string USER_LOCK = "Tài khoản của bạn bị khoá do vi phạm quy định Server";
        public readonly string DUPLICATE_LOGIN = "Có người đăng nhập vào tài khoản của bạn";
        public readonly string DUPLICATE_LOGIN2 = "Tài khoản của bạn đã được đăng nhập ở nơi khác, hãy thử lại sau";
        public readonly string INCORRECT_LOGIN = "Tài khoản hoặc mật khẩu không chính xác";
        public readonly string INCORRECT_NAME_LENGTH = "Tên đệ tử phải từ 5 - 15 ký tự";
        public readonly string INCORRECT_NAME = "Tên nhân vật không đúng định dạng, hãy dùng tên khác";
        public readonly string DUPLICATE_CHAR = "Tên nhân vật này đã tồn tại";
        public readonly string DUPLICATE_CLAN = "Tên clan này đã tồn tại";
        public readonly string IN_CLAN = "Bạn đã ở trong 1 bang hội từ trước rồi";
        public readonly string IN_CLAN_2 = "Người chơi này đã ở trong bang hội";
        public readonly string IN_CLAN_3 = "Người chơi {0} đã ở trong bang hội từ trước";
        public readonly string IN_CLAN_4 = "Người chơi {0} đã ở trong bang hội khác";
        public readonly string SUCCESS_CREATE_CLAN = "Bây giờ bạn đã là chủ của bang hội {0}";
        public readonly string ERROR_CREATE_CLAN = "Vui lòng thử lại sau";
        public readonly string ERROR_CREATE_NAME_CLAN = "Tên bang hội từ 3 đến 25 ký tự";
        public readonly string ERROR_CREATE_NEW_CHAR = "Tạo mới nhân vật lỗi";
        public readonly string GET_TASK = "Nhiệm vụ lần này của bạn là {0}";
        public readonly string NOT_ENOUGH_POWER = "Sức mạnh của bạn không đủ";
        public readonly string NOT_ENOUGH_PPOINT = "Bạn không có đủ tiềm năng để cộng điểm";
        public readonly string NOT_ENOUGH_BAG = "Hành trang của bạn không đủ chỗ trống";
        public readonly string NOT_ENOUGH_BOX = "Rương của bạn không đủ chỗ trống";
        public readonly string NOT_ENOUGH_DIAMOND = "Bạn không có đủ ngọc";
        public readonly string NOT_ENOUGH_GOLD = "Bạn không có đủ vàng";
        public readonly string NOT_ENOUGH_BUY_POWER = "Bạn không đủ sức mạnh để học chiêu thức này";
        public readonly string NOT_ENOUGH_BUY_PPOINT = "Bạn không đủ tiềm năng để học chiêu thức này";
        public readonly string NOT_ENOUGH_KI = "Bạn không đủ KI để sử dụng";
        public readonly string NOT_ENOUGH_HP = "Bạn không đủ HP để sử dụng";
        public readonly string NOT_ENOUGH_HP_DISCIPLE = "Sư phụ ơi, con sắp chết rồi nè";
        public readonly string NOT_ENOUGH_KI_DISCIPLE = "Sư phụ ơi, con hết mana mất rùi";
        public readonly string NOT_ENOUGH_STAMINA = "Thể lực đã hết";
        public readonly string NOT_ENOUGH_STAMINA_DISCIPLE = "Con hết thể lực rồi sư phụ ơi.";
        public readonly string NOT_ENOUGH_QUANTITY = "Số lượng vật phẩm không đủ";
        public readonly string DO_NOT_HEAL_FOR_ORTHER = "Không thể hồi phục cho đối phương";
        public readonly string DO_NOT_SELL_ITEM = "Không thể bán vật phẩm này";
        public readonly string THANKS_FOR_HEAL_ME = "Cảm ơn {0} đã hồi phục cho mình";
        public readonly string THANKS_FOR_SAVE_ME = "Cảm ơn {0} đã cứu mình";
        public readonly string THANKS_FOR_SAVE_ME_DIS = "Cảm ơn sư phụ";
        public readonly string ITEM_CANNOT_BE_DROPPED_HERE = "Bạn không thể bỏ vật phẩm tại đây";
        public readonly string ITEM_CANNOT_BE_DROPPED_NEAR_WP = "Bạn không thể bỏ vật phẩm gần lối ra vào";
        public readonly string CONFIRM_DROP_ITEM = "Bạn có muốn chắc huỷ bỏ (mất luôn)\n{0} ?";
        public readonly string CONFIRM_USE_ITEM = "Bạn có chắc muốn dùng\n{0} ?";
        public readonly string CANT_DROP_ITEM = "Bạn không thể vứt bỏ vật phẩm này";
        public readonly string MAX_PEAS = "Số đậu trong hành trang và rương đã đạt tối đa.";
        public readonly string MAX_NUMCHARS = "Số người trong khu đã đạt tối đa.";
        public readonly string MAX_NUMBERS_BOX = "Rương đồ đã được mở rộng tối đa";
        public readonly string MAX_NUMBERS_BAG = "Hành trang đã được mở rộng tối đa";
        public readonly string MAX_MEMBER = "Số lượng thành viên đã đạt tối đa";
        public readonly string NOT_LIVE_FROM_DEAD = "Bạn không có đủ 5 ngọc để hồi sinh.";
        public readonly string ADD_ITEM = "Bạn đã nhận được {0}";
        public readonly string ITEM_OF_ORTHER = "Vật phẩm của người khác";
        public readonly string SO_FAR = "Khoảng cách quá xa, không thể nhặt vật phẩm";
        public readonly string SO_FAR_SKILL = "Khoảng cách quá xa, không thể thi triển kỹ năng";
        public readonly string DONOT_USE_SKILL = "Bạn không thể học kỹ năng này";
        public readonly string DUPLICATE_USE_SKILL = "Bạn đã học kỹ năng này rồi";
        public readonly string CANT_YET_USE_SKILL = "Bạn chưa thể học kỹ năng này";
        public readonly string DO_YOU_ADD_SKILL = "Con có muốn học kỹ năng {0}\nCần {1} điểm tiềm năng và thời gian học là {2}";
        public readonly string ADDING_SKILL = "Con đang học kỹ năng\n{0} cấp {1}\nThời gian còn lại {2}";
        public readonly string NOT_GENDER = "Bạn không thể sử dụng vật phẩm này";
        public readonly string NOT_FLAG = "Bạn không thể đổi cờ này";
        public readonly string DELAY_CHANGEZONE = "Bạn chỉ có thể đổi khu vực sau {0} giây nữa";
        public readonly string NOT_CHANGEZONE = "Bạn không thể đổi khu vực này";
        public readonly string NOT_CHANGE_FLAG = "Bạn không thể đổi cờ tại đây";
        public readonly string DELAY_CHANGEFLAG = "Bạn chỉ có thể đổi cờ sau {0} giây nữa";
        public readonly string ERROR_DA_VUN = "Cần 10 mảnh đá vụn và 1 bình nước phép";
        public readonly string DOT_NOT_TEST_HERE = "Bạn không thể gửi lời mời thách đấu tại đây";
        public readonly string NOT_FOUND_PEA_IN_BOX = "Không tìm thấy đậu trong rương";
        public readonly string NOT_FOUND_CHAR_IN_MAP = "Không tìm thấy người chơi";
        public readonly string NOT_TRADE_WITH_PLAYER = "Chưa thể giao dịch với người chơi này";
        public readonly string NOT_TRADE_ITEM = "Vật phẩm này không thể giao dịch";
        public readonly string NOT_TEST = "Người chơi đang có lời mời thách đấu khác";
        public readonly string NOT_TEST_ME = "Bạn đang có yêu cầu thách đấu người chơi khác";
        public readonly string SEND_TEST = "Người chơi {0} có {1} sức mạnh muốn thách đấu bạn với mức cược {2} vàng";
        public readonly string DRAW_TEST = "Kết quả thách đấu hoà, bạn nhận lại 95% số tiền đã cược";
        public readonly string WON_TEST = "Bạn đã chiến thắng và nhận đượng 95% tổng tiền cược";
        public readonly string LOST_TEST1 = "Bạn đã thua vì kiệt sức";
        public readonly string LOST_TEST2 = "Bạn đã thua vì rời khỏi cuộc thách đấu";
        public readonly string ERROR_DRAGON_BALL = "Cần 7 viên ngọc rồng từ 2 sao trở lên";
        public readonly string SPLIT_BALL = "|2|Con muốn biến 7 viên {0} thành\n1 viên {1}\b|1|Cần 7 viên {2}";
        public readonly string PHA_LE_TRANG_BI = "{0} Sao pha lê";
        public readonly string PHA_LE_TRANG_BI_2 = "Tỉ lệ thành công: {0} %";
        public readonly string PHA_LE_TRANG_BI_3 = "Cần {0} Tr vàng";
        public readonly string PHA_LE_TRANG_BI_4 = "Nâng cấp\n{0} ngọc";
        public readonly string TRANG_BI_ERROR = "Trang bị không phù hợp";
        public readonly string NEED_SPL ="Yêu cầu trang bị cần có 1 sao pha lê trống trở lên ";
        public readonly string NEED_10_DIAMOND = "Cần 10 ngọc";
        public readonly string MAX_UPGRADE = "Trang bị đã đạt cấp tối đa";
        public readonly string TRANG_BI_ERROR_2 = "Cần chọn đúng trang bị và 1 loại đá nâng cấp";
        public readonly string NEED_ENOUGH_STONE = "Cần đủ đá nâng cấp";
        public readonly string PERCENT_UPGRADE = "Tỉ lệ thành công {0}";
        public readonly string IF_FAIL = "Nếu thất bại sẽ rớt xuống ";
        public readonly string NEED_TRUE_EQUIPMENT = "Cần 1 trang bị có cấp từ [+4] và 1 trang bị không có cấp nhưng cao hơn 1 bậc";
        public readonly string NEED_LEVEL_ITEM = "Cần trang bị từ lưỡng long trở lên hoặc trang bị thần linh trở xuống";
        public readonly string NEED_EQUIPMENT_SAME_KIND ="Chỉ được chuyển hoá trang bị cùng loại";
        public readonly string CONVERT_ALL_SPL = "Chuyển qua tất cả sao pha lê";
        public readonly string MAX_POINT = "Bạn không thể nâng thêm chỉ số này";
        public readonly string MAX_POINT_POWER = "Hãy mở giới hạn để cộng điểm này";
        public readonly string UPGRADE_LEVEL_ME = "Ta sẽ truyền năng lượng giúp con mở giới hạn sức mạnh\n của con lên {0} Tỉ\nLưu ý: từ 40 tỉ trở lên sức mạnh của con sẽ tăng chậm đáng kể\b|7|Giá nâng ngọc: {1} ngọc";
        public readonly string UPGRADE_LEVEL_CLONE = "Ta sẽ truyền năng lượng giúp con mở giới hạn sức mạnh\n của đệ tử lên {0} Tỉ\nLưu ý: từ 40 tỉ trở lên sức mạnh của đệ tử sẽ tăng chậm đáng kể\n";
        public readonly List<string> SKILL_BLIND = new List<string>(){"Chói mắt quá", "Mắt của ta", "Mù mắt ta rồi"};
        public readonly string DROP_PROTECT = "Khiên của bạn đã bị vỡ";
        public readonly string SELL_ITEM_GOLD = "Bạn nhận được {0} vàng";
        public readonly string DELAY_CHAT_TG = "Bạn chỉ có thể chat sau {0} giây nữa";
        public readonly string DELAY_CHANGE_SV = "Bạn chỉ có đổi máy chủ sau {0} giây nữa";
        public readonly string ERROR_VALUE_INPUT = "Giá trị nhập vào không chính xác";
        public readonly string DELAY_TRADE = "Bạn chỉ có thể giao dịch sau {0} giây nữa";
        public readonly string DELAY_REVICE_PEA = "Bạn chỉ có thể xin đậu sau 5 phút";
        public readonly string IN_TRADE = "Người chơi đang có giao dịch khác";
        public readonly string ME_IN_TRADE = "Bạn đang trong 1 giao dịch khác, hãy thoát map để huỷ bỏ";
        public readonly string CLOSE_TRADE = "Đối phương đã huỷ giao dịch";
        public readonly string TRADE_ERROR = "Giao dịch thất bại";
        public readonly string TRADE_SUCCESS = "Giao dịch thành công";
        public readonly string TRADE_HOLD = "Giao dịch đang được thực hiện...";
        public readonly string DO_YOU_WANT = "Bạn có muốn bán \b{0}x {1}\b với giá là {2} vàng?";
        public readonly string DONT_FIND_DISCIPLE = "Bạn chưa có đệ tử";
        public readonly string ADD_AMULET = "Bạn nhận được {0}, thời gian được cộng thêm 1 giờ";
        public readonly string ADD_FRIEND = "Người chơi {0} đã kết bạn với {1}";
        public readonly string ADD_FRIEND_2 = "Bạn đã kết bạn thành công với {0}";
        public readonly string USER_OFFLINE = "Hiện tại người chơi này không online";
        public readonly string FRIEND_NOT_FOUND = "Người chơi này không tồn tại";
        public readonly string FRIEND_DELETE = "Bạn đã xoá bạn bè với người chơi {0}";
        public readonly string ENEMY_DELETE = "Bạn đã xoá thù địch với người chơi {0}";
        public readonly string FRIEND_DUPLICATE = "Người chơi này đã có trong danh sách bạn bè";
        public readonly string TELEPORT_DELAY = "Bạn chỉ có thể dịch chuyển sau {0} giây nữa";
        public readonly string TELEPORT_ERROR = "Không thể dịch chuyển tới map của người chơi này";
        public readonly string INVITE_CLAN = "{0} mời bạn vào bang {0}";
        public readonly string ERROR_FIND_CLAN = "Không tìm thấy clan này";
        public readonly string ACCEPT_INVITE_CLAN = "Bây giờ bạn đã thành viên của: {0}";
        public readonly string RECEIVE_PEA_CLAN = "Bạn đã nhận được {0} từ {1}";
        public readonly string CHANGED_LEADER_CLAN = "Người chơi {0} đã được lên làm bang chủ";
        public readonly string CHANGED_SUBLEADER_CLAN = "Người chơi {0} đã được lên làm phó bang";
        public readonly string REMOVE_SUBLEADER_CLAN = "Người chơi {0} đã bị cách chức";
        public readonly string REMOVE_MEMBER = "Người chơi {0} đã bị kích khỏi bang";
        public readonly string LEAVE_CLAN = "Người chơi {0} đã rời bang";
        public readonly string DONT_LEAVE_CLAN = "Bạn chưa thể rời bang vào lúc này";
        public readonly string KICKED_CLAN = "Bạn đã bị kích khỏi bang hội";
        public readonly string PLEASE_INVITE_CLAN = "Người chơi {0} muốn xin vào bang hội";
        public readonly string JOINED_CLAN = "Người chơi {0} đã gia nhập bang hội";
        public readonly string CANCEL_LEARN_SKILL = "Bạn đã huỷ học kỹ năng thành công, nhận lại về 50% số tiềm năng";
        public readonly string LEVEL_CARD_MAX = "Thẻ này đã đạt cấp tối đa";
        public readonly string MAX_CARD_USE = "Số thẻ sử dụng đã đạt tối đa";
        public readonly string NOT_UNLOCK_CARD = "Thẻ này chưa được mở khoá";
        public readonly string LOCK_INVENTORY = "Rương của bạn đang bị khoá, hãy mở khoá để thực hiện thao tác";
        public readonly string ACTIVE_LOCK_INVENTORY = "Kích hoạt mã bảo vệ thành công";
        public readonly string UNACTIVE_LOCK_INVENTORY = "Mở khoá mã bảo vệ thành công";
        public readonly string SUCCESS_LOCK_INVENTORY = "Khoá rương thành công";
        public readonly string INVALID_LOCK_INVENTORY = "Mã bảo vệ không chính xác";
        public readonly string INVALID_LUCKY_NUMBER = "Con số may mắn phải từ 0 - 99";
        public readonly string INVALID_VALUE_LUCKY_NUMBER = "Con số may mắn phải từ 0 - 99, vàng >= 10,000, ngọc >= 20";
        public readonly string INVALID_GOLD_LUCKY_NUMBER = "Vàng phải >= 10,000";
        public readonly string INVALID_DIAMOND_LUCKY_NUMBER = "Ngọc phải >= 20";
        public readonly string SET_LUCKY_NUMBER = "Bạn đã chọn số may mắn {0}";
        public readonly string SET_LUCKY_NUMBER_WITH_VALUE = "Bạn đã chọn số may mắn {0}, với {1} vàng, {2} ngọc";
        public readonly string SET_GOLD_LUCKY_NUMBER = "Bạn đã cược thêm {0} vàng";
        public readonly string SET_DIAMOND_LUCKY_NUMBER = "Bạn đã cược thêm {0} ngọc";
        public readonly string END_TIME_SET_LUCKY_NUMBER = "Đã hết thời gian đặt cược";
        public readonly string GIFT_LUCKY_NUMBER = "Bạn nhận được: {0} vàng, {1} ngọc từ con số may mắn";
        public readonly string NOT_FOUND_DISCIPLE = "Bạn chưa nhận đệ tử nào";
        public readonly string HELLO_SP = "Xin chào sư phụ, con quay trở lại rồi nè";
        public readonly string CAN_NOT_USE_FUSION = "Bạn không thể hợp thể vào lúc này";
        public readonly string DELAY_FUSION_10M = "Bạn chỉ có thể hợp thể sau {0} phút nữa";
        public readonly string DELAY_FUSION_SEC = "Bạn chỉ có thể hợp thể sau {0} giây nữa";
        public readonly string FUSION_88 = "Chúc mừng bạn và đệ tử để hợp thành 1 thể đồng nhất";
        public readonly string DO_NOT_ACTION_DISCIPLE = "Bạn không thể thực hiện thao tác này";
        public readonly string MAX_POINT_SKILL_DISCIPLE = "Kỹ năng này của đệ tử đã đạt cấp tối đa";
        public readonly string SUCCESS_POINT_SKILL_DISCIPLE = "Nâng kỹ năng đệ tử thành công";
        public readonly string NOT_FOUND_SKILL_DISCIPLE = "Đệ tử của bạn chưa học kỹ năng này";
        public readonly string DONT_FIND_THE_DOI_TEN = "Bạn không có thẻ đổi tên";
        public readonly string DONT_CHANGE_NAME_HERE = "Bạn không thể đổi tên đệ tử tại đây";
        public readonly string DONT_NOT_ACTION_DISCIPLE_HERE = "Bạn không thể thực hiện tại đây";
        public readonly string SUCCESS_CHANGE_NAME_DISCIPLE = "Bạn đã đổi tên đệ tử";
        public readonly string LIMIT_ONE_ITEM_IN_BAG = "Bạn chỉ có thể sở hữu 1 vật phẩm.";
        public readonly string NOT_ENOUGH_DRAGON_BALL = "Bạn không có đủ 7 viên ngọc rồng";
        public readonly string INVALID_COUNTRY = "Bạn cần phải đứng tại {0}";
        public readonly string INVALID_PLACE_CALL_DRAGON = "Không thể gọi rồng thần tại đây";
        public readonly string DISCIPLE_NOT_ENOUGH_POWER = "Sức mạnh của đệ không đủ";
        public readonly string MAX_LIMIT_GOLD = "Bạn đã tăng tối đa giới hạn vàng trên người";
        public readonly string UPGRADE_LIMIT_GOLD = "Đã nâng giới hạn vàng lên {0} vàng";
        public readonly string INPUT_CORRECT_NUMBER = "Vui lòng nhập số hợp lệ";
        public readonly string INPUT_VND_TO_GOLD = "Nhập số tiền VNĐ muốn đổi sang Vàng";
        public readonly string LABEL_VND_TO_GOLD = "Bạn hiện có {0} VNĐ. Tỉ lệ đổi 1k VNĐ = 550k Vàng";
        public readonly string NAP_VANG = "Hãy truy cập web NRO Galaxy để xem hướng dẫn nạp thêm VNĐ rồi quay lại đây nhé.";
        public readonly string VND_TO_GOLD_LIMIT = "Đã đạt giới hạn vàng mang trên người, bạn chỉ có thể quy đổi tối đa {0} VND";
        public readonly string GOLD_BAR_TO_GOLD_LIMIT = "Bạn không thể đổi thêm thỏi vàng thành vàng được nữa, vì đã đạt giới hạn vàng trên người.";
        public readonly string NOT_ENOUGH_VND = "Bạn không có đủ VNĐ";
        public readonly string NOT_PREMIUM = "Bạn không phải là thành viên chính thức, vui lòng đổi vàng tại NPC Santa để nâng hạng";
        public readonly string PLAYER_NOT_PREMIUM = "Người chơi đó không phải là thành viên chính thức";
        public readonly string UPGRADE_TO_PREMIUM = "Xin chúc mừng bạn đã là thành viên chính thức của NRO Galaxy";
        public readonly string NOT_PREMIUM_LIMIT_POWER = "Bạn đã đạt giới hạn 40 tỷ sức mạnh, hãy nâng cấp lên thành viên chính thức để mở khóa.";
        public readonly string DISCIPLE_NOT_PREMIUM_LIMIT_POWER = "Sư phụ ơi, nâng cấp thành viên chính thức đi, con hết up sức mạnh được rồi nè.";
        public readonly List<string> BOSS_CHAT_IDLE = new List<string>(){"Tránh ra nào.", "Ta đang rất tức giận đó.", "Ngươi làm ta cáu rồi đấy."};
        public readonly List<string> BOSS_CHAT_COMBAT = new List<string>(){"Ta sẽ cho người biết tay.", "Tránh xa ta ra", "Ngươi làm ta cáu rồi đấy."};
        public readonly List<string> BOSS_CHAT_DIE = new List<string>(){"Ngươi được lắm. Ta sẽ trở lại.", "Hãy nhớ mặt của ta.", "Ngươi làm ta cáu rồi đấy."};
        public readonly List<string> BOSS_MOON_CHAT_IDLE = new List<string>(){"Cắc cùm cum, fuk tùm lum.", "Đập đá không bạn.", "Ngươi làm ta cáu rồi đấy."};
        public readonly List<string> BOSS_MOON_CHAT_COMBAT = new List<string>(){"Nói ngay số đá còn lại mày đang giấu ở đâu.", "Hãy đỡ lấy", "Ngươi làm ta cáu rồi đấy."};
        public readonly List<string> BOSS_MOON_CHAT_DIE = new List<string>(){"Ngươi được lắm. Ta sẽ trở lại.", "Hãy nhớ mặt của ta.", "Mày đợi tao đi lấy súng, hãy đợi đấy."};
        public readonly string DA_CO_TRUNG_MABU = "Không thể nhặt vì bạn đã có một quả trứng Thần bí ở nhà";
        public readonly string PLEASE_NOT_FUSION = "Không thể thực hiện khi đang hợp thể";
        public readonly string GET_NEW_MABU_DISCIPLE = "Đệ tử Thần bí đang đợi bạn bên ngoài";
        public readonly string INPUT_SERI_THE = "Nhập số seri";
        public readonly string INPUT_PIN_THE = "Nhập mã pin";
        public readonly string NHAP_TT_THE = "Nhập thông tin thẻ nạp";
        public readonly string PLEASE_USE_PORATA = "Vui lòng sử dụng Bông Tai Porata";
        public readonly string PLEASE_USE_PORATA_2 = "Vui lòng sử dụng Bông Tai Porata Cấp 2";
        public readonly string TRANG_BI_ERROR_PORATA_2 = "Cần chọn đúng bông tai porata và mảnh vỡ bông tai";
        public readonly string TRANG_BI_ERROR_PORATA_2_FIRST = "Bạn cần chọn bông tai Porata bỏ vào trước";
        public readonly string TRANG_BI_ERROR_PORATA_2_SECOND = "Bạn cần bỏ vào đủ 9999 mảnh vỡ bông tai";
        public readonly string UPGRADE_OPTION_PORATA_2_ERROR_COUNT = "Cần chọn đúng bông tai Porata cấp 2, mảnh hồn porata và đá xanh lam, theo đúng thứ tự";
        public readonly string UPGRADE_OPTION_PORATA_2_FIRST = "Bạn cần chọn bông tai Porata cấp 2 bỏ vào trước";
        public readonly string UPGRADE_OPTION_PORATA_2_SECOND = "Bạn cần bỏ vào mảnh hồn bông tai x99 cái";
        public readonly string UPGRADE_OPTION_PORATA_2_THIRD = "Bạn cần bỏ vào đá xanh làm cuối cùng";
        public readonly string NEED_GOLD = "Cần {0} vàng";
        public readonly string NEED_DIAMOND = "Cần {0} ngọc";
        public readonly string LIMIT_MUA_MANH_VO = "Bạn đã mua đủ giới hạn mảnh vỡ bông tai của hôm nay, mai mua tiếp nhé";
        public readonly string GET_GOLD_BAR = "Bạn đã nhận được {0} thỏi vàng";
        public readonly string START_AUTO_PLAY = "Bạn đã bắt đầu tự động luyện tập";
        public readonly string END_AUTO_PLAY = "Bạn đã ngừng tự động luyện tập";
        public readonly string FULL_LUCKY_BOX = "Rương phụ của con đã đầy";
        public readonly string DELETED_ALL_LUCKY_BOX = "Đã xóa tất cả vật phẩm trong rương phụ";
        public readonly string LIMIT_GOI_RONG = "Đã hết lượt gọi rồng thần hôm nay";
        public readonly string RONG_THAN_DANG_XUAT_HIEN = "Rồng thần đang đáp ứng điều ước cho người khác";
        public readonly string DELAY_CALL_DRAGON_SEC = "Bạn chỉ có thể gọi rồng sau {0} giây nữa";
        public readonly string DELAY_SEC = "Vui lòng đợi {0} giây nữa";
        public readonly string DELAY_RESTART_SEC = "Máy chủ vừa khởi động lại, để ổn định dữ liệu, vui lòng đợi {0} giây nữa";
        public readonly string LIMIT_TRAIN_MANH_VO = "Bạn đã đạt giới hạn nhận được mảnh vỡ bông tai hôm nay";
        public readonly string LIMIT_TRAIN_MANH_HON = "Bạn đã đạt giới hạn nhận được mảnh hồn bông tai hôm nay";
        public readonly string PLEASE_USE_PEA = "Hãy ăn đậu để tiếp tục đánh quái";
        public readonly string LIMIT_TRADE_POWER = "Bạn cần đạt 20 tỷ sức mạnh trở lên mới có thể giao dịch";
        public readonly string NOT_PREMIUM_TRADE_GOLD = "Chỉ có tài khoản thành viên chính thức mới có thể giao dịch số vàng trên 100tr";
        public readonly string PLAYER_NOT_PREMIUM_TRADE_GOLD = "Người chơi bạn giao dịch phải là thành viên chính thức mới có thể giao dịch số vàng trên 100tr";
        public readonly string NOT_PREMIUM_TRADE_GOLD_BAR = "Chỉ có tài khoản thành viên chính thức mới có thể giao dịch được {0}";
        public readonly string NOT_PREMIUM_TRADE_SPL_ITEM = "Chỉ có tài khoản thành viên chính thức mới có thể giao dịch được trang bị có sao pha lê";
        public readonly string NOT_PREMIUM_TRADE_LEVEL_ITEM = "Chỉ có tài khoản thành viên chính thức mới có thể giao dịch được trang bị có cấp bậc";
        public readonly string PLAYER_NOT_PREMIUM_TRADE_SPL_ITEM = "Người chơi đó không phải là thành viên chính thức, không thể giao dịch được trang bị có sao pha lê";
        public readonly string PLAYER_NOT_PREMIUM_TRADE_LEVEL_ITEM = "Người chơi đó không phải là thành viên chính thức, không thể giao dịch được trang bị có cấp bậc";
        public readonly string PLAYER_NOT_PREMIUM_TRADE_GOLD_BAR = "Người chơi bạn giao dịch phải là thành viên chính thức mới có thể giao dịch được {0}";
        public readonly string MESSAGE_TO_LONG = "Nội dung chat quá dài";
        public readonly string PLEASE_EMPTY_DISCIPLE_BODY = "Vui lòng tháo hết đồ của đệ tử ra trước.";
        public readonly string DISCIPLE_NOT_ENOUGH_POWER_TO_OPEN_EGG = "Đệ tử của bạn phải đạt sức mạnh 160tr trở lên mới có thể nở trứng Thần bí";
        public readonly string CAT_BOT_THUC_AN = "Hành trang đã đầy thức ăn cùng loại, vui lòng cất bớt thức ăn";
        public readonly string NOT_ENOUGH_ITEM = "Bạn không có đủ vật phẩm";
        public readonly string INPUT_CHANGE_PASS = "Đổi mật khẩu";
        public readonly string INPUT_CURRENT_PASS = "Mật khẩu hiện tại";
        public readonly string INPUT_NEW_PASS = "Mật khẩu mới";
        public readonly string INPUT_REG_SDT = "Số điện thoại";
        public readonly string SPLIT_GOLD_FIRST = "Nếu số lượng thỏi vàng lớn hơn 99 hãy tách nó ra trước.\nBấm vào thỏi vàng và chọn SỬ DỤNG trong hành trang của bạn.";
        public readonly string CSKB_GET = "Bạn đã mở ra được {0}";
        public readonly string DOT_IT_ON_NORMAL = "Chức năng này hiện chỉ có trên máy chủ thường";
        public readonly List<string> CHAT_SEXY = new List<string>(){"Wow, Very sẹc xi", "Woww, Em đẹp lắm", "Wow, idol của tui"};
        public readonly string RADAR_REQUIRE = "Bạn cần sưu tầm {0} ở cấp đô {1} mới có thể sử dụng thẻ này";

        public readonly string RANDOM_LINH_THU = "Úm ba la, con thú gì đây, con thú gì đây";
    }
}