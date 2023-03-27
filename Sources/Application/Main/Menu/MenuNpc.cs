using System.Collections.Generic;
using NRO_Server.Application.IO;
namespace NRO_Server.Main.Menu
{
    public class MenuNpc
    {
        private static MenuNpc _instance;

        public MenuNpc()
        {
            
        }

        public static MenuNpc Gi()
        {
            if (_instance == null) _instance = new MenuNpc();
            return _instance;
        }

        public List<List<string>> MenuAdmin = new List<List<string>>()
        {
            new List<string>()
            {
                "Item",
                "Boss",
                "Check\nGifcode",
                "Task",
                "DeathNote",
                "Map",
                "Ban",
                "Potential",
                "Point",
                "Money",
            },


         };
		 public List<List<string>> MenuVados = new List<List<string>>()
        {
            new List<string>()
            {
                "Nâng Áo",
                "Nâng Quần",
                 "Nâng Găng",
                  "Nâng Giày",
                   "Nâng Rada",
            },
             new List<string>()
            {
               "Nâng cấp",
               "Từ chối",
            },
             new List<string>()
            {
              "Hủy",
             },

        };
		 
		 public List<string> TextDuongTang = new List<string>()
        {
            "A mi phò phò, thí chủ Khi tới nhiệm vụ tương lai sẽ có thể vào map ngũ hành sơn để Up ngọc\n"+"|7|Map Up Ngọc NRO Galaxy",
            "Thí chủ muốn trở về sao ?",
            "A mi phò phò, thí chủ thu nhập bùa '[Giải Khai Phong Ấn]',Mỗi chữ 10 cái",
        };
         public List<List<string>> MenuDuongTang = new List<List<string>>()
        {
            new List<string>()
            {
                "Đồng ý",
                "Từ chối",
                //"Nhận thưởng",
            },
            new List<string>()
            {
                "Đồng ý", 
                "Từ chối",
            },
            new List<string> ()
            {
            "Giải\nPhong Ấn",
            "Về\nLàng Aru",
            "Top\nHoa Quả",
            }
        };
        
        public List<string> TextBaOngGia = new List<string>()
        {
            "Ta có thể giúp gì cho con?",
            "Con đã học kỹ năng thành công",
            "Hãy chọn máy chủ con muốn đổi"
        };

        public List<List<string>> MenuBaOngGia = new List<List<string>>()
        {
            new List<string>()
            {
                "Nhận ngọc",
                "Nhận vàng",
                //"Giftcode",
                //"Nhận Đệ tử",
                "Đổi\nMật khẩu",
                //"Bật/Tắt\nhiệu ứng\nđánh boss",
                "BXH\nSự kiện\nTop nạp",
                "BXH\nSự kiện\nSức mạnh",
                "Giftcode",
                // "Đổi máy chủ"
            },
            new List<string>()
            {
                "SV 01",
                "SV VIP"
            },
        };
		
		public List<string> TextGoldShop = new List<string>()
        {
            "Tính bug nữa sao, có làm mới có ăn nhé!.\nBán online item liên hệ ad Galaxy",
        };

        public List<List<string>> MenuGoldShop = new List<List<string>>() 
        {
            new List<string>()
            {
                "Mở shop",
                "Đóng",
            },
        };
		
		public List<string> TextCayThong = new List<string>()
        {
            "Xuân ba tháng, tết ba ngày\nCòn mùng là còn tết, còn thở là còn gỡ!.",
        };

        public List<List<string>> MenuCayThong = new List<List<string>>() 
        {
            new List<string>()
            {
                "Mở thường",
                "Mở VIP",
                "Đóng",
            },
        };

        public List<string> TextMeo = new List<string>()
        {
            "Bạn có muốn nâng cấp đậu thần không",
            "Bạn có muốn huỷ nâng cấp đậu thần không (nhận lại 50% vàng)",
            "Bạn có muốn kết bạn với {0} không?",
            "Bạn có muốn xoá kết bạn với {0} không?",
            "Bạn có muốn dịch chuyển tới người chơi {0} không?\bTốn 10 ngọc để dịch chuyển và thời gian tự do là 20 phút",
            "Bạn có chắc chắn muốn rời bang hội ?",
            "{0} (sức mạnh {1})\nBạn muốn cược bao nhiêu vàng?",
            "Bạn có muốn xoá {0} khỏi danh sách thù địch không?",
            "Bạn chưa từng kích hoạt mã bảo vệ lần nào\nBạn có muốn dùng 50k vàng để kích hoạt không, mã bảo vệ của bạn là: {0}",
            "Bạn có muốn mở khoá rương không?",
            "Bạn có muốn khoá rương lại không?",
        };

        public List<List<string>> MenuMeo = new List<List<string>> ()
        {
            new List<string>()
            {
                "OK", 
                "Huỷ",
            },
            new List<string>()
            {
                "Đồng ý", 
                "Huỷ",
            },
            new List<string>()
            {
                "1,000\nvàng", 
                "10,000\nvàng", 
                "100,000\nvàng"
            },
        };

        public List<string> TextNoiBanh= new List<string>()
        {
            "Chào mừng bạn tới sự kiện 8/3.Bạn muốn đổi gì?",
            "|7|Đổi bó hoa\n|0|x10 hoa hồng đỏ + 25tr vàng = 1 bó hoa hồng đỏ\n|0|x10 hoa hồng xanh + 25tr vàng = 1 bó hoa hồng xanh\n|0|x10 hoa hồng vàng + 25tr vàng = 1 bó hoa hồng vàng",         
            "Để làm ra một bó hoa hồng đỏ cần x10 hoa hồng đỏ + 50tr vàng. Bạn có đồng ý không?",
            "Để làm ra một bó hoa hồng xanh cần x10 hoa hồng xanh + 50tr vàng. Bạn có đồng ý không?",
            "Để làm ra một bó hoa hồng vàng cần x10 hoa hồng vàng + 50tr vàng. Bạn có đồng ý không?",
            "|7|Đổi giỏ hoa\n|0|x10 bó hoa hồng đỏ + 1 giỏ hoa + 50tr vàng = 1 giỏ hoa hồng đỏ\n|0|x10 bó hoa hồng xanh + 1 giỏ hoa + 50tr vàng = 1 giỏ hoa hồng xanh\n|0|x10 bó hoa hồng vàng + 1 giỏ hoa + 50tr vàng = 1 giỏ hoa hồng vàng",
            "Để làm ra một giỏ hoa hồng đỏ cần x10 bó hoa hồng đỏ + 1 giỏ hoa + 50tr vàng. Bạn có đồng ý không?",
            "Để làm ra một giỏ hoa hồng xanh cần x10 bó hoa hồng xanh + 1 giỏ hoa + 50tr vàng. Bạn có đồng ý không?",
            "Để làm ra một giỏ hoa hồng vàng cần x10 bó hoa hồng vàng + 1 giỏ hoa + 50tr vàng. Bạn có đồng ý không?",
            "|7|Đổi hộp quà 8/3\n|0|x1 giỏ hoa hồng đỏ + xanh + vàng + 50tr vàng = hộp quà 8/3\n|0|x5 giỏ hoa hồng đỏ + xanh + vàng + thiệp chúc mừng đỏ + 50tr vàng = 1 hộp quà đỏ 8/3\n|0|x5 giỏ hoa hồng đỏ + xanh + vàng + thiệp chúc mừng đỏ + thiệp chúc mừng xanh + 50tr vàng = 1 hộp quà VIP 8/3",
            "Để đổi Hộp Quà 8/3 cần x1 bó hoa hồng đỏ, x1 bó hoa hồng xanh, x1 bó hoa hồng vàng + 50tr vàng. Bạn có đồng ý không?",
            "Để đổi Hộp Quà Đỏ 8/3 cần x5 bó hoa hồng đỏ, x5 bó hoa hồng xanh, x5 bó hoa hồng vàng, x1 Thiệp chúc mừng đỏ. Bạn có đồng ý không?",
            "Để đổi Hộp Quà Đỏ 8/3 cần x10 bó hoa hồng đỏ, x10 bó hoa hồng xanh, x10 bó hoa hồng vàng, x1 Thiệp chúc mừng đỏ, x1 Thiệp chúc mừng xanh. Bạn có đồng ý không?",
        };
        
        public List<List<string>> MenuNoiBanh = new List<List<string>>()
        {
            new List<string>()
            {
                "Đổi Bó Hoa", 
                "Đổi giỏ Hoa",
                "Đổi hộp quà 8/3",
            },
            new List<string>()
            {
                "Đổi Bó hoa hồng đỏ", 
                "Đổi Bó hoa hồng xanh",
                "Đổi Bó hoa hồng vàng",
            },
            new List<string>()
            {
                "Đổi giỏ hoa hồng đỏ", 
                "Đổi giỏ hoa hồng xanh",
                "Đổi giỏ hoa hồng vàng",
            },
            new List<string>()
            {
                "Đổi hộp quà 8/3", 
                "Đổi hộp quà đỏ 8/3",
                "Đổi hộp quà VIP 8/3",
            },
            new List<string>()
            {
                "Đồng ý", 
                "Hủy",
            },
        };


        public List<string> TextThanMeo= new List<string>()
        {
            "Muốn uống nước thánh không cưng?",
            $"{ServerUtils.Color("red")}Bảng đổi điểm sự kiện xem tại thông báo của NRO \b"+
             $"{ServerUtils.Color("blue")}300 điểm : x10 đá bảo vệ, 5 viên cs trung thu, 10 thỏi vàng\b" + 
             $"{ServerUtils.Color("blue")}500 điểm : x15 đá bảo vệ, 10 viên cs trung thu, 10 thỏi vàng\b" + 
             $"{ServerUtils.Color("blue")}1000 điểm : x20 đá bảo vệ, 25 viên cs trung thu, item Lồng đèn, 20 thỏi vàng\b" + 
             $"{ServerUtils.Color("blue")}3000 điểm : x30 đá bảo vệ, x99 viên cs trung thu, item lồng đèn, 30 thỏi vàng\b" + 
             $"{ServerUtils.Color("blue")}5000 điểm : x35 đá bảo vệ, x99 viên cs trung thu, item lồng đèn, 35 thỏi vàng, ngẫu nhiên (phóng lợn, mèo mun, v.v)\b" + 
             $"{ServerUtils.Color("blue")}5000 điểm : x35 đá bảo vệ, x99 viên cs trung thu, item lồng đèn, 35 thỏi vàng, ngẫu nhiên (phóng lợn, mèo mun, v.v)\b" + 
             $"{ServerUtils.Color("blue")}7000 điểm : x50 đá bảo vệ, x99 viên cs trung thu, item lồng đèn, 40 thỏi vàng, ngẫu nhiên item, trang bị hủy diệt 10% trở lên\b" + 
             $"{ServerUtils.Color("blue")}10000 điểm : x99 đá bảo vệ, x99 viên cs trung thu, item lồng đèn, 50 thỏi vàng, ngẫu nhiên item, trang bị hủy diệt 12% trở lên\b" + 
            $"{ServerUtils.Color("red")}BẠN CHỈ CÓ THỂ ĐỔI ĐIỂM DUY NHẤT MỘT LẦN",
            "Vui lòng chọn loại lồng đèn muốn nhận?",
        };
        
        public List<List<string>> MenuThanMeo = new List<List<string>>()
        {
            new List<string>()
            {
                "Đổi quà sự kiện", 
                //"Đổi quà tích nạp",
            },
            //đổi sự kiện
            new List<string>()
            {
                "Đổi", 
                "Đóng",
            },
            //chọn lồng đèn
            new List<string>()
            {
                "SỨC ĐÁNH", 
                "HP",
                "KI",
                "CHÍ MẠNG",
                "GIÁP",
            },
        };

        public List<string> TextBaHatMit = new List<string>()
        {
            "Ngươi tìm ta có việc gì ?",
            "|2|Con muốn biến 10 mảnh đá vụn thành\n1 viên đá nâng cấp ngẫu nhiên\b|1|Cần 10 Mảnh đá vụ\nCần 1 bình nước phép\b|2|Cần 2 k vàng",
            "Ngươi Muốn pha lê hoá trang bị bằng cách nào",
            "Ta sẽ biến trang bị mới cấp cao hơn của ngươi thành trang bị có cấp độ và sao pha lê của trang bị cũ"
        };
        
        public List<List<string>> MenuBaHatMit = new List<List<string>>()
        {
            new List<string>() // 0
            {
                "Thưởng Bùa Ngẫu Nhiên", 
                "Cửa hàng Bùa", 
                "Nâng cấp Vật phẩm", 
                "Mở chỉ số Linh thú", 
                "Nhập Ngọc Rồng",
                "Nâng cấp\nBông tai\nPorata"
            },
            new List<string>() // 1
            {
                "Cửa hàng Bùa", 
                "Nâng cấp Vật phẩm", 
                "Làm phép Nhập đá", 
                "Nhập Ngọc Rồng",
                "Nâng cấp\nBông tai\nPorata"
            },
            new List<string>() // 2
            {
                "Bùa 1h", 
                "Bùa 8h",
                "Bùa\n1 Tháng"
            },
            new List<string>() // 3
            {
                "Ép sao\ntrang bị", 
                "Pha lê\nhoá\ntrang bị", 
                "Nâng cấp\nLinh thú"
            },
            new List<string>() // 4
            {
                "Vào hành trang\nChọn trang bị\n(Áo,quần,găng,giày hoặc rada)\nChọn loại đá để nâng cấp\nSau đó chọn 'Nâng cấp'", 
                "Ta sẽ phù phép\ncho trang bị của ngươi\ntrở nên mạnh mẽ"
            },
            new List<string>() // 5
            {
                "Vào hành trang\nChọn 10 mảnh đá vụn\nChọn 1 bình nước phép\nSau đó chọn 'Làm phép'", 
                "Ta sẽ phù phép\ncho 10 mảnh đá vụn\ntrở thành 1 đá nâng cấp "
            },
            new List<string>() // 6
            {
                "Vào hành trang\nChọn 7 viên ngọc cùng sao\nSau đó chọn 'Làm phép'", 
                "Ta sẽ phù phép\ncho 7 viên Ngọc Rồng\nthành 1 viên Ngọc Rồng cấp cao"
            },
            new List<string>() // 7
            {
                "Làm phép\n2k vàng", 
                "Từ chối"
            },
            new List<string>()  // 8
            {
                "Vào hành trang\nChọn trang bị\n(Áo,quần,găng,giày hoặc rada)\nSau đó chọn 'Nâng cấp'", 
                "Ta sẽ phù phép\ncho trang bị của ngươi\ntrở thành trang bị pha lê"
            },
 

            new List<string>()//9
            {
                "Bằng ngọc", 
                "Từ chối"
            }, 

            new List<string>() // 10 
            {
                "Chuyển hoá\nDùng vàng", 
                "Chuyển hoá\nDùng ngọc"
            },

            new List<string>() // 11
            {
                "Vào hành trang\nChọn trang bị\n(Áo,quần,găng,giày hoặc rada)có ô đặt\n sao pha lê\n Chọn loại sao pha lê\nSau đó chọn 'Nâng cấp'",
                "Ta sẽ phù phép\ncho trang bị của ngươi\ntrở nên mạnh mẽ"
            },

            new List<string>() // 12
            {
                "Vào hành trang\n Chọn trang bị gốc\n (Áo,quần,găng,giày,rada) \ntừ cấp 4 trở lên\nChọn tiếp trang bị mới\nchưa nâng cấp cần nhập thể\nsau đó chọn 'Nâng cấp'",
                "Lưu ý trang bị mới\n phải hơn trang bị cũ 1 bậc"
            },
            new List<string>()  // 13 nâng cấp porata cấp 2
            {
                "Vào hành trang\nChọn bông tai Porata\nChọn mảnh vỡ bông tai để nâng cấp, số lượng\n9999 cái\nSau đó chọn 'Nâng cấp'", 
                "Ta sẽ phù phép\ncho bông tai Porata của người\nthành cấp 2"
            },
            new List<string>()  // 14 mở chỉ số porata cấp 2
            {
                "Vào hành trang\nChọn bông tai Porata cấp 2\nChọn mảnh hồn porata số lượng 99 cái và\nđá xanh lam để nâng cấp.\nSau đó chọn 'Nâng cấp'", 
                "Ta sẽ phù phép\ncho bông tai Porata cấp 2 của người\ncó 1 chỉ số ngẫu nhiên"
            },

            new List<string>() // 15
            {
                "Nở trứng\nLinh thú", 
                "Mở chỉ số\nLinh thú", 
                "Đổi chỉ số\nLinh thú", 
                "Nâng cấp\nLinh thú",
            },
            new List<string>() // 16
            {
                "Vào hành trang\nChọn 1 trứng linh thú\nChọn 99 hồn linh thú\n(Chọn 50 thỏi vàng nếu ngươi muốn nở nhanh)\nSau đó chọn 'Nâng cấp'", 
                "Ta sẽ làm phép\n cho trứng của ngươi sẽ nở"
            },
            new List<string>() // 17
            {
                "Vào hành trang\nChọn linh thú hạng C\nChọn 1x99 hồn linh thú\nChọn 2 thỏi vàng\nSau đó chọn 'Nâng cấp'", 
                "Ta sẽ làm phép\n mở chỉ số cho linh thú của ngươi"
            },
            new List<string>() // 18
            {
                "Vào hành trang\nChọn 1 linh thú có chỉ số\nChọn 99 hồn linh thú\nChọn 1 thỏi vàng\nSau đó chọn 'Nâng cấp'", 
                "Ta sẽ làm phép\n đổi chỉ số cho linh thú của ngươi"
            },
            new List<string>() // 19
            {
                "Vào hành trang\nChọn 2 linh thú cùng bậc thường để nâng cấp CỘNG\nHOẶC\n1 linh thú cấp CỘNG và 1 linh thú cấp thường để nâng hạng\n(Yêu cầu cùng loại linh thú\nvà cùng loại chỉ số)\nSau đó chọn 'Nâng cấp'", 
                "Ta sẽ làm phép\n linh thú của ngươi sẽ tiến hóa"
            }
        };
        
        public List<string> TextBumma = new List<string>()
        {
            "Cưng cần trang bị gì cứ đến chỗ chị nhé",
            "Chị chỉ bán đồ cho người Trái Đất thôi nha cưng!",
        };
        
        public List<List<string>> MenuShopDistrict = new List<List<string>>()
        {
            new List<string>()
            {
                "Cửa hàng",
            },
            new List<string>()
            {
                "Cửa hàng", 
                "Từ chối",
            },
        };
        
        public List<string> TextDende = new List<string>()
        {
            "Anh, chị cần trang bị gì cứ đến chỗ em nhé",
            "Em... Chỉ bán đồ cho người Namếc thôi...!",
        };
        public List<string> TextAppule = new List<string>()
        {
            "Cậu cần trang bị gì cứ đến chỗ tôi nhé",
            "Ta chỉ bán đồ cho người Xayda siêu mạnh thôi, cút về hành tinh của ngươi mà mua đi!",
        };
        
        public List<string> TextBrief= new List<string>()
        {
            "Tàu vũ trụ Trái Đất sử dụng công nghệ mới nhất, có thể đưa ngươi đi bất kì đâu, miễn có tiền trả là được.",
            "Ta sẽ đưa ngươi trở về hành tinh của mình an toàn!",
        };
        
        public List<List<string>> MenuBrief = new List<List<string>>()
        {
            new List<string>()
            {
                "Đến Xayda", 
                "Đến Namếc", 
                "Siêu thị",
            },
            new List<string>()
            {
                "Đến Xayda", 
                "Đến Namếc",
            },
        };
        
        public List<string> TextCargo= new List<string>()
        {
            "Tàu vũ trụ Namec sử dụng công nghệ mới nhất, có thể đưa ngươi đi bất kì đâu, miễn có tiền trả là được.",
        };
        
        public List<List<string>> MenuCargo = new List<List<string>>()
        {
            new List<string>()
            {
                "Đến\nTrái Đất", 
                "Đến Xayda", 
                "Siêu thị",
            },
            new List<string>()
            {
                "Đến\nTrái Đất", 
                "Đến Xayda", 
            },
        };
        
        public List<string> TextCui = new List<string>()
        {
            "Tàu vũ trụ Xayda sử dụng công nghệ mới nhất, có thể đưa ngươi đi bất kì đâu, miễn có tiền trả là được.",
            "Đội quân Fide đang ở thung lũng Nappa, ta sẽ đưa ngươi đến đó",
            "Ngươi muốn về thành phố Vegeta ?",
            "Ngươi muốn đến chỗ KuKu ?",
            "Ngươi muốn đến chỗ Mật Đầu Đinh ?",
            "Ngươi muốn đến chỗ Rambo ?",
        };
        
        public List<List<string>> MenuCui = new List<List<string>>()
        {
            new List<string>()
            {
                "Đến\nTrái Đất", "Đến Namếc", "Siêu thị",
            },
            new List<string>()
            {
                "Đến\nTrái Đất", "Đến Namếc", 
            },
            new List<string>()
            {
                "Đến Cold", "Đến Nappa", "Từ Chối"
            },
            new List<string>()
            {
                "Đồng ý", "Từ Chối"
            },
            new List<string>()
            {
                "Đến chỗ KuKu", "Từ Chối"
            },
            new List<string>()
            {
                "Đến chỗ Mập Đầu Đinh", "Từ Chối"
            },
            new List<string>()
            {
                "Đến chỗ Rambo", "Từ Chối"
            },
        };
        
        public List<string> TextQuyLao = new List<string>()
        {
            "Con muốn hỏi gì nào?",
            "Chào con, to rất vui khi gặp con\nCon muốn làm gì nào?",
            "Mở vào ngày 10/11",
            "Con có muốn huỷ học kỹ năng này và nhận lại 50% số tiềm năng không ?",
        };
        
        public List<List<string>> MenuQuyLao = new List<List<string>>()
        {
            new List<string>()
            {
                "Nói\nchuyện", "Kho báu\ndưới biển"
            },
            new List<string>()
            {
                "Nhiệm vụ", "Học\nKỹ năng"
            },
            new List<string>()
            {
                "Top\nBang hội", "Thành\ntích bang", "Chọn\ncấp độ", "Từ chối"
            },
        };
        
        public List<string> TextSanta = new List<string>()
        {
            "Xin chào, ta có một số vật phẩm đặc biệt, cậu có muốn xem không?",
            "Giới hạn vàng của bạn đang là {0} vàng, bạn có muốn nâng thêm 200Tr không?",
            "|0|Con đang có: {0} VND\nTổng Nạp: {1} VND",
            "|7|Con đang có: {0} VND",
            "|7|Con đang có: {0} VND\n|6|Muốn kích hoạt thành viên cần 20.000 VND\n|6|Sau khi kích hoạt sẽ nhận ct sự kiện , nhớ để 1 slot ô đồ trống",
            "|7|Con đang có: {0} VND\n|6|Con muốn đổi vàng hay ngọc ?",
            "|7|Con đang có: {0} VND\n|6|SHOP BUÔN ĐÁ...nhớ để 2 slot ô đồ trống\n|0|Lựa chọn 1. 10k VND = 5 viên đá Vĩnh Hằng và 5 đá Hắc Hóa\n|0|Lựa chọn 2. 100k VND = 50 viên đá Vĩnh Hằng và 50 đá Hắc Hóa\n|0|Lựa chọn 3. 1 viên đá Ngũ Sắc = 5.000 VND\n|0|Lựa chọn 4. 10 viên đá Ngũ Sắc = 50.000 VND ",
        };
        
        public List<List<string>> MenuSanta = new List<List<string>>()
        {
            new List<string>()
            {
                "Giftcode", "Cửa\nhàng", "Tiệm\nHớt tóc", "Đổi tiền"
            },
            new List<string>()
            {
                "Nâng 200Tr\nGiá 200Tr", "Từ chối"
            },
            new List<string>()
            {
                "Đổi vàng\nngọc", "Kích hoạt\nThành viên","Đập đá", "Từ chối"
            },
            new List<string>()
            {
                "Đổi vàng","Đổi Ngọc",
            },
            new List<string>()
            {
                "10K\n50 Thỏi","20K\n100 Thỏi", "50K\n250 Thỏi", "100k\n500 Thỏi", "200k\n1000 Thỏi", "500k\n2500 Thỏi"
            },
            new List<string>()
            {
                "10K\n100K Ngọc","20K\n200K Ngọc", "50K\n500K Ngọc", "100k\n1m Ngọc", "200k\n2m Ngọc", "500k\n5m Ngọc"
            },
            new List<string>()
            {
                "OK","Hủy"
            },
            new List<string>()
            {
                "Tùy chọn\n1","Tùy chọn\n2","Tùy chọn\n3","Tùy chọn\n4","Hủy"
            }
        };
        
        public List<string> TextQuocVuong = new List<string>()
        {
            "Con muốn nâng giới hạn sức mạnh\ncho bản thân hay đệ tử?"
        };
        
        public List<List<string>> MenuQuocVuong = new List<List<string>>()
        {
            new List<string>()
            {
                "Bản thân", "Đệ tử", "Từ chối"
            },
            new List<string>()
            {
                "Nâng\nGiới hạn\nSức mạnh","Nâng ngọc","OK"
            },
            new List<string>()
            {
                "Nâng ngay\ncho đệ tử\n%d ngọc","OK"
            },
        };

        public List<string> TextThuongDe = new List<string>()
        {
            "",
            "Con đã mạnh hơn ta, ta sẽ chỉ đường cho con đến Kaio để gặp thần Vũ Trụ Phương Bắc\nNgài là thần cai quản vũ trụ này, hãy theo ngài ấy học võ công",
            "Con có thể chọn từ 1 đến 7 viên\ngiá mỗi viên là 25 tr vàng\nƯu tiên dùng vé quay trước",
            "Con có chắc muốn xóa tất cả vật phẩm trong rương phụ không?"
        };

        public List<List<string>> MenuThuongDe = new List<List<string>>()
        {
            new List<string>()
            {
                "Bản thân"
            },
            new List<string>()
            {
                "Vòng quay\nMay mắn",
                "Đến\nKaio"
            },
            new List<string>()
            {
                "Vòng quay\nMay mắn",
                "Đóng",
            },
            new List<string>()
            {
                "Xóa",
                "Từ chối",
            },
        };

        public List<string> TextThanVuTru = new List<string>()
        {
            "Con muốn điều gì?",
        };

        public List<List<string>> MenuThanVuTru = new List<List<string>>()
        {
            new List<string>()
            {
                "Về Thần Điện",
                "Từ chối"
            },
        };

        // Rồng thần
        public string TextRongThan = "Ta sẽ ban cho ngươi 1 điều ước, hãy suy nghĩ thật kỹ trước khi quyết định";
		
        // Rồng thần
        public string TextRongXuong= "Ta sẽ ban cho ngươi 1 điều ước, hãy suy nghĩ thật kỹ trước khi quyết định";

        public List<string> MenuDieuUocRongThan = new List<string>()
        {
            "2 tỷ vàng",
            "+1 Găng tay trên người (Max 7)",
            "Đổi skill 2,3 đệ tử",
            "Đẹp trai nhất vũ trụ",
            "Đổi skill 3,4 đệ tử"
        };
		
		public List<string> MenuDieuUocRongXuong = new List<string>()
        {
            "2 tỷ ngọc",
            "+1 Găng tay đệ tử (Max 7)",
            "Đổi kỹ năng 3, 4 đệ tử",
            "Xấu trai nhất vũ trụ"
        };

        // Trứng ma bư
        public List<string> TextQuaTrung = new List<string>()
        {
            "Bạn có chắc chắn thay thế để tự hiện tại thành đệ tử Thần Bí?",
            "Hãy chọn hành tinh cho đệ tử Thần Bí của bạn.",
        };

        public List<List<string>> MenuQuaTrung = new List<List<string>>()
        {
            new List<string>()
            {
                "{0}",
                "Nở Ngay\n1,1 Tỷ Vàng",
                "Đóng",
            },
            new List<string>()
            {
                "Nở",
                "Đóng",
            },
            new List<string>()
            {
                "Trái Đất",
                "Namếc",
                "Xayda"
            },
        };

        // Text nạp card
        public List<string> TextNapThe = new List<string>()
        {
            "Con hãy chọn loại thẻ mà con muốn nạp.",
            "Tốt lắm, giờ con hãy chọn mệnh giá thẻ nạp trước khi nhập mã nha\nLưu ý: Khi chọn sai mệnh giá sẽ bị trừ 50%."
        };


        public List<List<string>> MenuNapThe = new List<List<string>>()
        {
            new List<string>()
            {
                "Viettel",
                "Vinaphone",
                "Mobifone",
                "Zing",
                "Hủy"
            },
            new List<string>()
            {
                "10,000đ",
                "20,000đ",
                "30,000đ",
                "50,000đ",
                "Mệnh giá\nkhác",
                "Hủy",
            },
            new List<string>()
            {
                "100,000đ",
                "200,000đ",
                "300,000đ",
                "500,000đ",
                "1,000,000đ",
                "Hủy",
            },
        };

        // Text nội tại
        public List<string> TextNoiTai = new List<string>()
        {
            "Nội tại là một kỹ năng bị động hỗ trợ đặc biệt\nBạn có muốn mở hoặc thay đổi nội tại không?",
            "Bạn có muốn đổi Nội Tại khác với giá là {0} ngọc?",
            "Bạn có muốn mở Nội Tại Bằng Vàng với giá là {0} vàng?"
        };

        public List<List<string>> MenuNoiTai = new List<List<string>>() 
        {
            new List<string>()
            {
                "Xem\ntất cả\nNội tại",
                "Mở Nội Tại",
                "Mở Bằng Vàng",
                "Từ chối"
            },
            new List<string>()
            {
                "Mở Nội Tại",
                "Từ chối"
            },
            new List<string>()
            {
                "Mở Bằng Vàng",
                "Từ chối"
            },
        };

        // Ca lich
        public List<string> TextCalich = new List<string>()
        {
            "Chào chú, cháu có thể giúp gì?",
            @"20 năm trước bọn Android sát thủ đã đánh bại nhóm bảo vệ trái đất của Sôngoku và Cađíc, Pôcôlô..
            Riêng Sôngoku vì bệnh tim đã chết trước đó nên không thể tham gia trận đánh...
            Từ đó đến nay bọn chúng tàn phá Trái Đất không hề thương tiếc. Cháu và mẹ may mắn sống sót nhờ lẩn trốn tại tầng hầm của công ty Capsule...
            Cháu tuy cũng là siêu Xayda nhưng cũng không thể làm gì được bọn Android sát thủ...
            Chỉ có Sôngoku mới có thể đánh bại bọn chúng, mẹ cháu đã chế tạo thành công cỗ máy thời gian và cháu quay về quá khứ để cứu Sôngoku...
            Bệnh của Gôku ở quá khứ là nan y, nhưng với trình độ y học tương lai chỉ cần uống thuốc là khỏi...
            Hãy đi theo cháu đến tương lai giúp nhóm Gôku đánh bại bọn Android sát thủ. Khi nào chú cần sự giúp đỡ của cháu hãy đến đây nhé.",
        };

        public List<List<string>> MenuCalich = new List<List<string>>() 
        {
            new List<string>()
            {
                "Kể chuyện",
                "Đi đến\nTương lai",
                "Từ chối",
            },
            new List<string>()
            {
                "Quay về\nQuá khứ",
                "Từ chối",
            },
        };

        public List<string> TextGiuMa = new List<string>()
        {
            "Khi ngươi hoàn thành Nhiệm vụ Gia nhập bang hội, ta sẽ đưa ngươi đến đó.",
        };

        public List<List<string>> MenuGiuMa = new List<List<string>>() 
        {
            new List<string>()
            {
                "OK",
                "Đóng",
            },
        };

        public List<string> TextBill = new List<string>()
        {
            "Ngươi tìm ta có việc gì.",
            "Ngươi trang bị đủ bộ 5 món trang bị Thần\nvà mang 99 phần đồ ăn tới đây...\nrồi ta nói chuyện tiếp.",
            "Đói bụng quá...ngươi mang cho ta 99 phần đồ ăn, ta sẽ đổi cho một món đồ Hủy Diệt bằng THỎI VÀNG.\nNếu tâm trạng ta vui ngươi có thể nhận được trang bị tăng đến 15%"
        };


        public List<List<string>> MenuBill = new List<List<string>>() 
        {
            new List<string>()
            {
                "Nói chuyện",
                "Từ chối",
            },
            new List<string>()
            {
                "OK",
            },
            new List<string>()
            {
                "OK",
                "Từ chối",
            },
        };

        public List<string> TextTrungThu= new List<string>()
        {
            "Vui trung thu cùng sever để nhận được nhiều phần quà hấp dẫn.\nBạn muốn xem gì?",
        };
        public List<string> TextCTnew= new List<string>()
        {
            "Tính bug nữa sao, có làm mới có ăn nhé!.\nBán online item liên hệ ad Galaxy",
        };
        public List<List<string>> MenucT = new List<List<string>>()
        {
            new List<string>()
            {
                 "Cửa hàng\nCai Trang",
                //"BXH\nSự kiện\nTop nạp",
            },
        };
        public List<List<string>> MenuTrungThu = new List<List<string>>()
        {
            new List<string>()
            {
                 "Cửa hàng\nTrung thu",
                 "BXH\nSự kiện\nTrung thu", 
                //"BXH\nSự kiện\nTop nạp",
            },
        };
    }
}