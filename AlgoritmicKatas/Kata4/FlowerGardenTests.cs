﻿using NUnit.Framework;

public class FlowerGardenTests
{
    [TestCase(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 1, 1, 1, 1 }, new[] { 365, 365, 365, 365, 365 }, new[] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 5, 10, 15, 20 }, new[] { 4, 9, 14, 19, 24 }, new[] { 5, 4, 3, 2, 1 })]
    [TestCase(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 5, 10, 15, 20 }, new[] { 5, 10, 15, 20, 25 }, new[] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 5, 10, 15, 20 }, new[] { 5, 10, 14, 20, 25 }, new[] { 3, 4, 5, 1, 2 })]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 3, 1, 3, 1, 3 }, new[] { 2, 4, 2, 4, 2, 4 }, new[] { 2, 4, 6, 1, 3, 5 })]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 3, 3, 1, 1, 3 }, new[] { 2, 4, 4, 2, 2, 4 }, new[] { 2, 3, 6, 1, 4, 5 })]
    [TestCase(new[] { 689, 929, 976, 79, 630, 835, 721, 386, 492, 767, 787, 387, 193, 547, 906, 642, 3, 920, 306, 735, 889, 663, 295, 892, 575, 349, 683, 699, 584, 149, 410, 710, 459, 277, 965, 112, 146, 352, 408, 432 }, new[] { 4, 123, 356, 50, 57, 307, 148, 213, 269, 164, 324, 211, 249, 355, 110, 280, 211, 106, 277, 303, 63, 326, 285, 285, 269, 144, 331, 15, 296, 319, 89, 243, 254, 159, 185, 158, 81, 270, 219, 26 }, new[] { 312, 158, 360, 314, 323, 343, 267, 220, 347, 197, 327, 334, 250, 360, 350, 323, 291, 323, 315, 320, 355, 334, 286, 293, 362, 181, 360, 328, 322, 344, 173, 248, 284, 301, 215, 230, 226, 331, 355, 81 }, new[] { 149, 3, 79, 193, 112, 146, 432, 277, 386, 349, 410, 295, 306, 352, 387, 408, 547, 459, 492, 575, 663, 683, 976, 584, 630, 642, 689, 699, 787, 735, 835, 710, 721, 767, 889, 892, 906, 920, 965, 929 })]
    [TestCase(new[] { 401, 267, 259, 760, 846, 105, 126, 717, 669, 864, 449, 87, 276, 670, 861, 60, 660, 28, 94, 788, 111, 305, 580, 848, 163, 112, 355 }, new[] { 219, 345, 30, 234, 14, 338, 301, 69, 50, 204, 33, 85, 137, 293, 50, 304, 227, 330, 309, 286, 349, 185, 291, 339, 339, 157, 290 }, new[] { 343, 358, 365, 336, 295, 350, 351, 84, 52, 324, 363, 356, 183, 350, 222, 329, 362, 342, 358, 305, 356, 363, 365, 343, 350, 311, 353 }, new[] { 60, 28, 87, 94, 112, 105, 111, 126, 163, 259, 276, 267, 305, 355, 401, 449, 717, 669, 580, 660, 670, 848, 760, 788, 846, 861, 864 })]
    [TestCase(new[] { 977, 847 }, new[] { 351, 39 }, new[] { 358, 278 }, new[] { 977, 847 })]
    [TestCase(new[] { 239, 878, 182, 109, 510, 581, 643, 402, 470, 849, 196, 707, 810, 913, 758, 261, 451, 240, 624, 60, 671, 363, 300, 40, 22, 229, 755, 82, 8, 949, 906, 411, 17, 566 }, new[] { 296, 136, 306, 94, 345, 37, 11, 133, 269, 276, 199, 348, 277, 324, 146, 252, 52, 138, 37, 5, 231, 314, 230, 138, 202, 340, 235, 58, 99, 123, 272, 67, 48, 277 }, new[] { 301, 317, 339, 271, 361, 148, 117, 291, 357, 331, 282, 354, 342, 341, 178, 261, 158, 357, 177, 208, 323, 336, 256, 182, 228, 342, 326, 236, 358, 315, 325, 200, 358, 341 }, new[] { 8, 17, 239, 229, 182, 40, 22, 60, 82, 109, 196, 240, 363, 261, 300, 402, 470, 566, 671, 755, 810, 849, 510, 707, 411, 451, 581, 624, 758, 878, 906, 949, 913, 643 })]
    [TestCase(new[] { 515, 298, 806, 115, 384, 389, 450, 865, 323, 463, 191, 279, 420, 9, 29, 601, 696, 534, 837, 137, 992, 683, 3, 218, 436, 238, 354, 342, 234, 274, 205, 748, 653, 101 }, new[] { 222, 98, 200, 263, 131, 363, 48, 152, 203, 136, 123, 50, 52, 338, 31, 235, 38, 209, 35, 137, 199, 330, 7, 322, 257, 300, 207, 83, 183, 324, 259, 267, 58, 305 }, new[] { 322, 349, 277, 278, 256, 364, 191, 249, 301, 283, 172, 361, 221, 339, 226, 286, 194, 321, 93, 313, 341, 336, 269, 335, 259, 324, 252, 125, 225, 345, 289, 362, 76, 331 }, new[] { 389, 101, 218, 9, 3, 115, 29, 137, 238, 274, 234, 205, 191, 279, 298, 683, 342, 323, 436, 354, 384, 420, 450, 653, 463, 696, 837, 515, 534, 601, 748, 806, 865, 992 })]
    [TestCase(new[] { 355, 432, 141, 84, 544, 650, 777, 499, 709, 764 }, new[] { 251, 18, 324, 87, 145, 118, 152, 52, 171, 160 }, new[] { 293, 200, 344, 234, 197, 281, 275, 342, 261, 262 }, new[] { 355, 141, 84, 432, 499, 544, 650, 709, 764, 777 })]
    [TestCase(new[] { 310, 856, 224, 225, 895, 731, 68, 164, 243, 862, 492, 423, 628, 500, 883, 4, 615, 223, 627, 65, 361, 123, 884, 427, 636, 618, 812, 37, 44, 325, 555 }, new[] { 235, 73, 255, 10, 280, 9, 8, 333, 24, 74, 141, 226, 1, 89, 8, 319, 226, 139, 247, 212, 226, 356, 144, 359, 241, 77, 158, 28, 237, 362, 173 }, new[] { 331, 236, 326, 283, 342, 268, 55, 359, 214, 329, 287, 237, 172, 229, 142, 355, 304, 324, 251, 291, 247, 362, 228, 365, 365, 109, 299, 246, 341, 365, 196 }, new[] { 123, 325, 37, 68, 4, 44, 164, 427, 65, 223, 224, 225, 310, 361, 423, 243, 492, 500, 618, 628, 615, 627, 636, 555, 731, 812, 856, 862, 895, 884, 883 })]
    [TestCase(new[] { 220, 439, 658, 590, 11, 312, 139, 846, 425, 644, 589, 634, 185, 848, 182, 912, 500, 479, 434, 428, 437, 690, 229, 423, 158 }, new[] { 11, 280, 162, 359, 313, 128, 192, 315, 265, 227, 221, 102, 173, 143, 97, 292, 144, 322, 323, 148, 25, 260, 243, 242, 84 }, new[] { 60, 295, 209, 365, 334, 206, 232, 344, 357, 331, 343, 231, 245, 191, 230, 318, 232, 354, 338, 243, 171, 310, 301, 363, 148 }, new[] { 220, 158, 139, 182, 185, 312, 229, 11, 423, 590, 428, 437, 500, 425, 439, 434, 479, 589, 634, 658, 848, 644, 846, 690, 912 })]
    [TestCase(new[] { 901, 184, 719, 179, 494, 385, 114, 698, 498, 956, 824, 380, 995, 603, 582, 883, 791, 182, 533, 618, 625, 225, 319, 140, 2, 500, 774, 838, 793, 465, 850, 178, 422, 301, 395, 9, 710, 949 }, new[] { 114, 270, 7, 343, 318, 261, 276, 185, 342, 334, 96, 272, 90, 242, 294, 213, 6, 320, 94, 223, 254, 278, 195, 187, 134, 148, 133, 348, 180, 108, 343, 267, 156, 283, 109, 33, 256, 270 }, new[] { 268, 287, 282, 354, 320, 342, 305, 351, 359, 361, 227, 293, 110, 266, 319, 322, 26, 323, 162, 245, 335, 358, 320, 188, 217, 219, 248, 357, 295, 309, 349, 313, 182, 361, 191, 63, 364, 354 }, new[] { 182, 179, 114, 178, 184, 225, 301, 9, 2, 319, 380, 385, 498, 494, 140, 395, 422, 465, 603, 618, 582, 625, 500, 698, 710, 838, 850, 533, 719, 791, 774, 793, 824, 995, 883, 949, 956, 901 })]
    [TestCase(new[] { 791, 483, 846, 331, 686, 593, 451, 23, 605, 437, 82, 84, 53, 171, 781, 666, 689, 714, 928, 643, 826, 100, 130, 337, 947, 197, 442, 383, 43, 234 }, new[] { 152, 266, 166, 362, 311, 220, 207, 350, 78, 135, 334, 91, 262, 191, 227, 6, 188, 353, 136, 293, 240, 337, 122, 353, 147, 271, 315, 74, 305, 65 }, new[] { 298, 340, 200, 363, 356, 332, 334, 353, 339, 196, 362, 108, 342, 345, 365, 37, 216, 365, 287, 363, 338, 338, 343, 360, 323, 292, 320, 220, 362, 220 }, new[] { 666, 84, 23, 43, 53, 82, 337, 331, 100, 130, 171, 442, 234, 383, 437, 197, 451, 483, 593, 605, 689, 643, 686, 714, 781, 791, 846, 826, 928, 947 })]
    [TestCase(new[] { 487, 975, 884, 712, 769, 179, 919, 789, 858, 729, 108, 935, 590, 571, 286, 221, 629, 315, 30, 486, 173, 218, 536, 175, 27, 484, 36, 373, 157, 753, 795, 274, 51, 222, 248, 743, 738, 210, 997, 505, 895, 376, 891 }, new[] { 276, 72, 46, 163, 160, 279, 116, 89, 110, 288, 242, 270, 8, 131, 350, 265, 191, 307, 249, 26, 184, 112, 296, 244, 138, 50, 322, 189, 64, 70, 19, 176, 283, 76, 126, 163, 165, 262, 206, 246, 282, 308, 313 }, new[] { 358, 186, 106, 285, 362, 315, 241, 186, 155, 349, 306, 350, 154, 325, 351, 323, 312, 341, 286, 351, 297, 146, 308, 301, 200, 170, 330, 222, 191, 356, 42, 342, 323, 172, 294, 335, 246, 309, 278, 313, 287, 345, 357 }, new[] { 286, 36, 30, 51, 108, 27, 157, 218, 222, 173, 175, 179, 210, 221, 248, 484, 274, 373, 315, 376, 486, 487, 505, 536, 571, 629, 729, 712, 738, 743, 590, 795, 753, 769, 895, 891, 935, 789, 884, 858, 919, 997, 975 })]
    [TestCase(new[] { 388, 957, 557, 397, 624, 683, 787, 615, 80, 109, 352, 771, 442, 196, 263 }, new[] { 84, 34, 225, 52, 189, 326, 43, 181, 179, 354, 357, 108, 169, 72, 16 }, new[] { 165, 278, 315, 118, 275, 356, 119, 360, 360, 362, 360, 307, 278, 221, 146 }, new[] { 80, 196, 442, 557, 263, 388, 397, 109, 352, 615, 683, 624, 771, 787, 957 })]
    [TestCase(new[] { 205, 258, 557, 429, 99, 529, 905, 687, 599, 943 }, new[] { 48, 258, 227, 71, 210, 247, 325, 23, 103, 218 }, new[] { 214, 274, 336, 94, 218, 324, 352, 69, 132, 264 }, new[] { 258, 529, 557, 905, 99, 943, 205, 687, 599, 429 })]
    [TestCase(new[] { 638, 545, 71, 259, 260, 458, 87, 542, 764 }, new[] { 107, 5, 270, 123, 239, 271, 217, 202, 112 }, new[] { 291, 143, 328, 240, 335, 353, 284, 303, 116 }, new[] { 71, 87, 259, 545, 260, 458, 542, 638, 764 })]
    [TestCase(new[] { 397, 268, 40, 35, 676, 939, 436, 496, 206, 67, 424, 361, 352, 592, 729, 98, 778, 495, 413, 497, 582, 618, 585, 622, 942, 701, 258, 835, 963, 678, 190, 288, 567, 96, 523, 373, 851, 893, 709, 307, 221, 243, 374, 285, 667, 127, 826, 328 }, new[] { 311, 68, 287, 345, 343, 4, 283, 238, 79, 258, 222, 148, 206, 140, 109, 306, 182, 234, 207, 308, 140, 356, 296, 331, 201, 225, 142, 16, 109, 205, 351, 4, 269, 271, 61, 238, 163, 323, 361, 338, 335, 268, 328, 44, 323, 126, 187, 296 }, new[] { 363, 110, 311, 355, 360, 352, 332, 263, 167, 296, 307, 308, 363, 322, 148, 327, 350, 278, 264, 318, 243, 363, 364, 360, 312, 350, 345, 255, 214, 261, 354, 189, 340, 293, 86, 240, 311, 336, 365, 343, 360, 306, 334, 178, 350, 306, 192, 323 }, new[] { 40, 98, 67, 96, 127, 243, 206, 268, 35, 190, 221, 258, 328, 307, 352, 374, 397, 285, 288, 523, 361, 373, 413, 424, 495, 496, 582, 436, 497, 567, 585, 618, 709, 622, 667, 676, 592, 729, 678, 701, 778, 893, 826, 835, 851, 939, 942, 963 })]
    [TestCase(new[] { 5, 896, 321, 204, 26, 730, 312, 112, 746, 861, 486, 948, 330, 185, 33, 343, 313, 755, 49, 779, 573, 346, 938, 145, 607, 139, 887, 254, 892, 844, 996, 293 }, new[] { 130, 274, 45, 261, 132, 136, 250, 37, 201, 125, 219, 203, 294, 111, 117, 182, 188, 286, 10, 40, 39, 57, 93, 144, 244, 123, 83, 338, 282, 161, 279, 211 }, new[] { 195, 287, 152, 283, 175, 256, 353, 112, 206, 136, 357, 244, 323, 259, 213, 228, 291, 313, 362, 189, 133, 269, 117, 299, 292, 338, 275, 345, 289, 293, 310, 229 }, new[] { 5, 26, 33, 49, 139, 254, 145, 204, 112, 185, 321, 312, 330, 293, 313, 343, 346, 573, 486, 607, 755, 730, 779, 861, 746, 844, 892, 887, 948, 938, 896, 996 })]
    [TestCase(new[] { 512, 899, 364, 114, 854, 332, 618, 219, 805, 648, 269, 626, 221, 202, 725, 968, 261, 998, 773, 447, 37, 959, 48, 82, 477, 161, 741, 361, 536, 465, 17, 479, 895, 892, 542, 815, 352 }, new[] { 297, 325, 256, 102, 327, 20, 95, 9, 116, 252, 291, 78, 84, 96, 99, 340, 334, 155, 48, 244, 227, 304, 194, 192, 195, 175, 126, 282, 33, 251, 140, 360, 341, 217, 298, 269, 58 }, new[] { 355, 357, 292, 248, 339, 238, 314, 145, 178, 320, 320, 85, 338, 121, 292, 342, 355, 311, 140, 270, 238, 345, 301, 251, 352, 212, 229, 337, 58, 352, 346, 362, 363, 218, 325, 313, 347 }, new[] { 479, 17, 37, 48, 82, 114, 202, 219, 161, 221, 332, 269, 261, 352, 626, 536, 361, 364, 447, 465, 477, 512, 895, 854, 542, 899, 618, 648, 725, 815, 959, 968, 741, 892, 773, 805, 998 })]
    [TestCase(new[] { 699, 654, 277, 88, 536, 42, 983, 642, 46 }, new[] { 257, 187, 137, 84, 167, 142, 80, 205, 50 }, new[] { 316, 249, 205, 200, 205, 326, 172, 224, 197 }, new[] { 42, 699, 46, 88, 277, 536, 983, 642, 654 })]
    [TestCase(new[] { 680, 477, 324, 106, 855, 610, 279, 880, 87, 137, 749, 568, 14, 746, 201, 231, 538, 878, 194, 752, 300, 110, 234, 760, 390, 55, 15, 8, 549, 50, 851, 815, 899, 512, 151, 977, 697, 272, 309, 925, 944 }, new[] { 280, 317, 24, 241, 153, 23, 12, 48, 46, 229, 339, 112, 28, 28, 326, 271, 62, 5, 161, 235, 191, 17, 347, 290, 126, 166, 28, 20, 354, 146, 41, 175, 87, 73, 287, 23, 206, 19, 221, 168, 148 }, new[] { 361, 352, 63, 286, 256, 288, 302, 162, 116, 240, 362, 135, 154, 161, 331, 312, 136, 274, 295, 296, 349, 170, 351, 329, 264, 181, 365, 329, 357, 286, 166, 314, 178, 132, 332, 298, 357, 248, 317, 272, 332 }, new[] { 8, 14, 15, 549, 234, 151, 201, 87, 50, 137, 106, 55, 110, 194, 272, 231, 279, 324, 300, 309, 477, 390, 512, 538, 568, 610, 746, 851, 680, 697, 752, 760, 815, 855, 878, 880, 899, 925, 944, 977, 749 })]
    [TestCase(new[] { 701, 903, 910, 569, 332, 216, 781, 288, 54, 441, 61, 724, 524, 782, 805, 563, 897, 323, 779, 360, 401, 957, 751, 597, 817, 451, 493, 436, 402, 319, 99 }, new[] { 146, 31, 179, 67, 192, 178, 102, 235, 323, 276, 10, 212, 99, 140, 69, 51, 266, 267, 206, 136, 107, 5, 340, 146, 246, 131, 343, 109, 301, 14, 156 }, new[] { 269, 311, 337, 237, 294, 213, 224, 359, 335, 330, 304, 296, 117, 187, 88, 273, 335, 294, 228, 217, 127, 318, 363, 232, 325, 294, 359, 348, 358, 201, 293 }, new[] { 61, 99, 216, 319, 401, 54, 288, 402, 323, 332, 360, 436, 524, 493, 751, 441, 451, 563, 569, 805, 597, 701, 724, 817, 897, 779, 781, 782, 903, 910, 957 })]
    [TestCase(new[] { 499, 238, 224, 821, 514, 905, 518, 743, 82, 140, 812, 127, 656, 955, 91 }, new[] { 160, 207, 54, 29, 141, 216, 334, 91, 334, 4, 333, 360, 245, 260, 109 }, new[] { 206, 350, 175, 108, 326, 286, 361, 99, 342, 238, 364, 365, 348, 364, 151 }, new[] { 127, 91, 140, 224, 743, 821, 499, 82, 238, 518, 514, 656, 905, 812, 955 })]
    [TestCase(new[] { 631, 695, 989, 27, 944, 297, 156, 690, 416, 293, 716, 6, 621, 282, 709, 547, 284, 830, 103, 85, 931, 751, 261, 332, 886, 966, 819, 279, 784, 474, 175, 626, 218, 436, 774, 292, 820, 791, 242, 531, 107, 252, 179, 790, 831, 742 }, new[] { 29, 237, 356, 236, 3, 97, 220, 319, 359, 111, 232, 126, 286, 199, 108, 240, 138, 142, 258, 273, 273, 335, 29, 279, 152, 229, 16, 79, 316, 82, 114, 261, 193, 55, 302, 42, 200, 355, 97, 135, 215, 76, 164, 4, 147, 210 }, new[] { 213, 343, 357, 251, 166, 293, 246, 343, 363, 162, 263, 341, 365, 252, 349, 290, 341, 240, 355, 334, 285, 350, 227, 352, 361, 251, 185, 298, 329, 281, 172, 340, 215, 204, 356, 160, 211, 356, 224, 156, 235, 301, 247, 14, 347, 358 }, new[] { 790, 416, 6, 175, 107, 85, 103, 27, 156, 179, 218, 242, 252, 261, 279, 282, 284, 292, 293, 297, 436, 332, 474, 547, 621, 626, 690, 695, 531, 631, 709, 819, 716, 742, 820, 830, 751, 774, 791, 784, 831, 886, 989, 966, 944, 931 })]
    [TestCase(new[] { 430, 85 }, new[] { 161, 140 }, new[] { 237, 349 }, new[] { 85, 430 })]
    [TestCase(new[] { 45, 752, 470, 771, 642, 374, 172, 498, 802, 102, 518, 41, 403, 464, 197, 929, 320, 406, 338, 842, 408, 989, 451, 217, 611, 898, 620, 672, 472, 336, 554, 697, 174, 968, 411, 289, 243, 241, 183 }, new[] { 131, 347, 329, 357, 219, 17, 358, 232, 168, 122, 125, 204, 296, 143, 264, 29, 364, 100, 6, 338, 187, 44, 106, 152, 78, 318, 25, 340, 237, 258, 83, 233, 46, 50, 280, 231, 330, 217, 71 }, new[] { 196, 349, 344, 365, 355, 129, 364, 250, 274, 285, 271, 282, 317, 303, 290, 322, 365, 224, 110, 351, 362, 129, 182, 194, 130, 364, 125, 346, 264, 261, 294, 277, 103, 74, 282, 306, 362, 332, 356 }, new[] { 174, 172, 320, 45, 41, 102, 183, 338, 374, 217, 197, 241, 406, 451, 289, 403, 336, 243, 408, 771, 470, 411, 464, 472, 498, 518, 554, 642, 752, 697, 802, 672, 842, 898, 611, 620, 929, 968, 989 })]
    [TestCase(new[] { 890, 330, 373, 323, 363, 636, 269, 768, 112, 734, 96, 245, 75, 607, 927, 655, 28, 254, 307, 127, 110, 14, 719, 787, 847, 652, 893, 878, 111, 856, 577, 326, 199, 723, 285, 31, 659, 996, 543, 128, 718, 643, 60 }, new[] { 342, 35, 213, 225, 339, 21, 121, 233, 241, 180, 92, 123, 128, 284, 283, 346, 54, 295, 124, 256, 38, 48, 348, 327, 311, 321, 23, 78, 334, 221, 86, 303, 108, 311, 356, 357, 219, 77, 279, 292, 24, 228, 38 }, new[] { 351, 131, 266, 231, 358, 194, 260, 329, 255, 286, 203, 277, 138, 333, 364, 354, 117, 347, 260, 325, 55, 352, 349, 337, 332, 342, 151, 92, 361, 289, 93, 308, 324, 341, 365, 362, 242, 103, 361, 331, 314, 326, 256 }, new[] { 31, 14, 111, 285, 28, 60, 127, 128, 112, 110, 75, 96, 199, 254, 363, 326, 543, 655, 719, 607, 245, 269, 307, 330, 577, 636, 323, 373, 643, 659, 718, 878, 893, 996, 734, 652, 890, 723, 768, 856, 787, 847, 927 })]
    [TestCase(new[] { 411, 754, 202, 788, 88 }, new[] { 163, 186, 43, 111, 329 }, new[] { 284, 340, 322, 338, 341 }, new[] { 202, 411, 88, 754, 788 })]
    [TestCase(new[] { 911, 10, 946, 398, 758, 679, 731, 656 }, new[] { 348, 254, 201, 140, 75, 58, 214, 293 }, new[] { 358, 356, 273, 364, 316, 181, 247, 364 }, new[] { 10, 398, 731, 679, 656, 911, 758, 946 })]
    [TestCase(new[] { 145, 180, 902 }, new[] { 112, 235, 204 }, new[] { 292, 357, 329 }, new[] { 145, 180, 902 })]
    [TestCase(new[] { 952, 341, 607, 208, 746, 467, 471, 174, 188, 342, 420, 594, 934, 880, 573, 110, 377, 264, 923, 915, 771, 612, 300, 202, 679, 556, 603, 810, 59, 531, 203, 611, 308, 948, 250, 659, 145, 991, 33, 664, 70, 945, 12, 869, 307, 296, 156 }, new[] { 164, 137, 33, 41, 148, 218, 86, 221, 34, 122, 122, 213, 69, 304, 127, 173, 4, 242, 318, 176, 44, 46, 163, 56, 222, 255, 57, 174, 45, 334, 121, 197, 152, 351, 96, 208, 118, 71, 161, 136, 364, 332, 203, 234, 94, 237, 303 }, new[] { 180, 290, 222, 285, 156, 328, 291, 356, 305, 297, 348, 236, 220, 332, 193, 345, 328, 325, 319, 255, 161, 172, 345, 107, 333, 357, 274, 193, 276, 341, 137, 272, 221, 352, 307, 344, 282, 94, 184, 320, 365, 346, 364, 260, 97, 296, 329 }, new[] { 33, 12, 70, 59, 110, 156, 145, 174, 188, 203, 202, 208, 250, 307, 264, 296, 300, 308, 341, 342, 377, 420, 531, 467, 471, 594, 573, 556, 948, 603, 607, 612, 611, 659, 664, 810, 746, 771, 679, 880, 945, 923, 869, 915, 934, 991, 952 })]
    [TestCase(new[] { 895, 263, 645, 773, 665, 328, 49, 976, 771, 638, 546, 395, 911, 707, 978, 826, 354, 296, 724, 469, 688, 542, 753, 492, 568, 813, 446, 340, 606, 388, 135, 44, 498 }, new[] { 193, 251, 97, 98, 85, 262, 92, 294, 221, 45, 117, 80, 174, 343, 251, 360, 241, 80, 69, 140, 271, 73, 223, 290, 331, 78, 249, 21, 350, 70, 160, 111, 33 }, new[] { 316, 268, 304, 274, 245, 302, 328, 327, 343, 186, 297, 174, 192, 355, 359, 362, 268, 269, 348, 225, 356, 199, 352, 354, 352, 142, 328, 78, 353, 309, 179, 352, 315 }, new[] { 826, 340, 44, 49, 263, 135, 296, 328, 354, 388, 446, 492, 568, 606, 395, 469, 498, 542, 546, 638, 645, 688, 707, 665, 724, 753, 771, 773, 911, 895, 976, 978, 813 })]
    [TestCase(new[] { 949, 696, 678, 67, 497, 569, 130, 90, 382, 220, 747, 734, 389, 452, 784, 147, 859, 296, 341, 963, 334, 163, 36, 462, 712, 1, 596, 413, 765, 630, 623, 735, 717, 440, 997, 587, 424, 228 }, new[] { 270, 153, 124, 30, 72, 276, 32, 175, 11, 23, 145, 248, 71, 165, 99, 97, 326, 5, 69, 266, 206, 173, 59, 323, 138, 154, 289, 316, 13, 217, 116, 309, 27, 154, 97, 208, 328, 22 }, new[] { 309, 324, 208, 168, 357, 296, 111, 335, 53, 322, 287, 342, 108, 315, 134, 162, 342, 47, 332, 363, 283, 343, 329, 344, 365, 257, 297, 332, 341, 310, 223, 352, 84, 228, 204, 273, 335, 279 }, new[] { 1, 36, 90, 163, 67, 130, 147, 220, 228, 334, 341, 440, 452, 413, 424, 462, 389, 497, 587, 623, 678, 569, 596, 630, 696, 712, 734, 747, 735, 296, 382, 717, 765, 949, 859, 963, 784, 997 })]
    [TestCase(new[] { 911, 368, 469, 170, 712, 669, 693, 673, 303, 436, 330, 384, 710, 795 }, new[] { 186, 65, 269, 313, 160, 361, 221, 160, 249, 345, 166, 315, 195, 158 }, new[] { 277, 257, 283, 335, 214, 362, 336, 214, 282, 363, 294, 362, 196, 361 }, new[] { 303, 330, 469, 368, 673, 710, 712, 170, 384, 693, 436, 669, 795, 911 })]
    [TestCase(new[] { 786, 670, 785, 726, 372, 223, 924, 360, 416, 849, 23, 977, 332, 128, 1000, 641, 683, 487, 958, 242, 515, 296, 92, 803, 674, 248, 793, 863, 774, 430, 734, 391, 365, 151, 761, 142, 359, 133, 192, 531, 845 }, new[] { 143, 42, 44, 184, 51, 229, 43, 90, 299, 138, 312, 147, 338, 207, 273, 174, 161, 81, 70, 121, 324, 118, 55, 100, 141, 44, 222, 363, 193, 228, 278, 263, 269, 353, 60, 55, 185, 48, 166, 205, 240 }, new[] { 296, 181, 120, 230, 191, 269, 173, 338, 307, 176, 329, 282, 346, 289, 307, 261, 291, 288, 319, 175, 356, 151, 168, 140, 201, 201, 281, 364, 312, 317, 322, 354, 278, 363, 327, 165, 226, 91, 292, 308, 302 }, new[] { 332, 151, 863, 128, 92, 192, 223, 133, 142, 242, 248, 359, 296, 23, 360, 372, 365, 391, 515, 416, 430, 487, 531, 641, 670, 674, 683, 734, 726, 761, 785, 803, 774, 786, 849, 924, 793, 845, 958, 977, 1000 })]
    [TestCase(new[] { 812, 71, 611, 428, 711, 643, 590, 783, 926, 994 }, new[] { 2, 14, 328, 129, 235, 187, 236, 8, 49, 131 }, new[] { 221, 253, 331, 170, 336, 297, 328, 116, 334, 198 }, new[] { 71, 783, 590, 643, 611, 711, 428, 812, 926, 994 })]
    [TestCase(new[] { 548, 147, 988, 639, 9, 895, 969, 675, 796 }, new[] { 62, 253, 199, 245, 358, 181, 132, 254, 124 }, new[] { 176, 345, 252, 249, 360, 197, 232, 279, 224 }, new[] { 639, 548, 796, 895, 969, 988, 147, 675, 9 })]
    [TestCase(new[] { 776, 826, 521, 242, 807, 565, 945, 606, 149, 698, 609, 857, 894, 234, 997, 382, 512, 43, 186, 504, 264, 878, 271, 143, 199, 973, 321, 126, 653, 819, 518, 901, 797, 57, 301, 975, 934, 209, 865, 983, 491, 67, 680, 828, 834 }, new[] { 29, 94, 166, 68, 161, 279, 35, 135, 145, 257, 139, 108, 224, 102, 217, 195, 282, 217, 178, 308, 186, 156, 87, 229, 112, 193, 328, 142, 79, 301, 114, 351, 74, 48, 264, 55, 184, 60, 323, 59, 293, 16, 212, 7, 63 }, new[] { 184, 150, 275, 150, 197, 333, 199, 292, 247, 312, 162, 225, 279, 104, 362, 285, 304, 344, 320, 352, 288, 204, 88, 344, 251, 337, 338, 180, 263, 341, 340, 355, 220, 207, 346, 135, 257, 186, 342, 340, 320, 265, 292, 344, 174 }, new[] { 57, 43, 67, 143, 126, 149, 186, 199, 209, 264, 301, 491, 382, 512, 321, 504, 901, 234, 242, 518, 565, 521, 606, 609, 271, 653, 776, 680, 797, 826, 807, 698, 819, 828, 865, 834, 857, 894, 878, 934, 945, 975, 973, 983, 997 })]
    [TestCase(new[] { 809, 556, 386, 446, 518, 574, 73, 75, 409 }, new[] { 146, 47, 298, 52, 25, 151, 230, 199, 117 }, new[] { 308, 185, 345, 332, 227, 176, 284, 336, 361 }, new[] { 73, 75, 386, 409, 446, 518, 556, 574, 809 })]
    [TestCase(new[] { 730, 882, 841, 120, 789 }, new[] { 51, 234, 354, 273, 115 }, new[] { 214, 319, 363, 331, 251 }, new[] { 841, 730, 789, 120, 882 })]
    [TestCase(new[] { 148, 735, 961, 975, 670, 533, 525, 290, 78, 440, 263, 139, 313, 27, 280, 761, 87, 204, 974, 408, 621, 461, 354 }, new[] { 242, 341, 250, 58, 23, 111, 304, 335, 90, 165, 180, 294, 51, 2, 175, 17, 68, 344, 179, 135, 334, 204, 281 }, new[] { 279, 357, 300, 325, 220, 274, 338, 341, 101, 255, 241, 343, 64, 67, 304, 258, 317, 345, 298, 324, 344, 207, 364 }, new[] { 204, 78, 87, 263, 148, 139, 290, 280, 354, 408, 525, 621, 735, 440, 461, 533, 27, 313, 670, 761, 961, 974, 975 })]
    [TestCase(new[] { 3, 2, 5, 4 }, new[] { 1, 2, 11, 10 }, new[] { 4, 3, 12, 13 }, new[] { 4, 5, 2, 3 })]
    [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, new[] { 1, 3, 1, 3, 1, 3 }, new[] { 2, 4, 2, 4, 2, 4 }, new[] { 2, 4, 6, 1, 3, 5 })]
    [TestCase(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 1, 1, 1, 1 }, new[] { 365, 365, 365, 365, 365 }, new[] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }, new[] { 1, 1, 5, 5, 10, 14, 14, 16, 17, 19, 31, 32, 33, 35, 36, 1, 38, 41, 43, 41, 45, 15, 60, 61, 58, 71, 72, 74, 75, 1 }, new[] { 2, 5, 6, 10, 15, 20, 15, 18, 18, 20, 32, 40, 34, 36, 37, 40, 40, 42, 44, 45, 90, 40, 70, 62, 62, 72, 73, 76, 76, 10 }, new[] { 34, 31, 41, 48, 49, 46, 47, 43, 44, 45, 33, 32, 11, 12, 13, 14, 15, 16, 20, 18, 19, 17, 35, 50, 38, 36, 37, 39, 40, 42 })]
    [TestCase(new[] { 5, 4, 3, 2, 1 }, new[] { 1, 5, 10, 15, 20 }, new[] { 5, 10, 15, 20, 25 }, new[] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 3, 3, 3, 1 }, new[] { 2, 4, 4, 4, 2 }, new[] { 2, 3, 4, 1, 5 })]
    [TestCase(new[] { 5, 3, 4, 2, 1 }, new[] { 1, 10, 5, 15, 20 }, new[] { 5, 15, 10, 20, 25 }, new[] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { 5, 1, 2, 3, 4 }, new[] { 1, 1, 6, 6, 6 }, new[] { 3, 3, 8, 8, 8 }, new[] { 2, 3, 4, 1, 5 })]
    [TestCase(new[] { 1, 2, 3 }, new[] { 1, 10, 1 }, new[] { 2, 11, 2 }, new[] { 2, 1, 3 })]
    [TestCase(new[] { 1, 3, 2 }, new[] { 1, 1, 10 }, new[] { 2, 2, 11 }, new[] { 2, 1, 3 })]
    [TestCase(new[] { 1, 4, 5, 3 }, new[] { 1, 1, 1, 3 }, new[] { 2, 2, 4, 4 }, new[] { 3, 1, 4, 5 })]
    [TestCase(new[] { 2, 1 }, new[] { 10, 5 }, new[] { 20, 30 }, new[] { 1, 2 })]
    [TestCase(new[] { 3, 2, 1 }, new[] { 1, 3, 1 }, new[] { 2, 4, 2 }, new[] { 2, 1, 3 })]
    [TestCase(new[] { 1, 5, 2, 3, 4 }, new[] { 1, 1, 5, 5, 5 }, new[] { 2, 2, 6, 6, 6 }, new[] { 2, 3, 4, 1, 5 })]
    [TestCase(new[] { 1, 2, 5, 4, 3, 8 }, new[] { 1, 90, 30, 40, 12, 40 }, new[] { 100, 150, 39, 60, 13, 300 }, new[] { 1, 5, 4, 3, 2, 8 })]
    public void FlowerGardenTest(int[] height, int[] bloom, int[] wilt, int[] expectedOrdering)
    {
        var fg = new FlowerGarden();

        var actualOrdering = fg.GetOrdering(height, bloom, wilt);

        CollectionAssert.AreEqual(expectedOrdering, actualOrdering);
    }
}