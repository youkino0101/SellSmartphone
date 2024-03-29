﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Common
{
   
    public enum StatusProject
    {
        InThePlan, // trong kết hoạch
        InProgress, // đang tiến hành
        Completed, // hoàn thành
        Paused, // tạm dừng
    }

    public enum StatusTask // Trạng thái công việc
    {
        New, // mới
        InProgress, // đang tiến hành
        Completed, // hoàn thành
        Canceled // đã hủy
    }

    public enum TaskPriority // Độ ưu tiên công việc 
    {
        Low, // thấp 
        Medium, // trung bình
        High, // cao
        Urgent // cấp bách
    }

    public enum StaffStatus
    {
        Active, //  hoạt động
        OnLeave // đã thôi việc
    }

    public enum ActivityType
    {
        Meeting, //  cuộc họp
        CallClient, // cuộc gọi với khách hàng
        Lunch, // hẹn ăn với khách hàng
        Orther // Khác
    }

    public enum ActivityStatus // Trạng thái công việc
    {
        UnConfirmed, // chưa xác nhận
        Confirmed, // đã xác nhận
        Completed, // hoàn thành
        Canceled // đã hủy
    }

    public enum QuoteStatus
    {
        Approved, // Báo giá đã được duyệt.
        Accepted, // Báo giá đã được chấp nhận bởi khách hàng.
        Expired, // báo giá hết hạn
        Rejected, // Báo giá bị từ chối.
    }
    public enum Status
    {
        Active, // hoạt động
        Lock, // khóa
        Canceled, // đã hủy
        Orther, // khác
    }

    public enum Category
    {
        SmartPhone, // điện thoại thông minh
        Ipad, // máy tính bảng
        Phone, // điện thoại bth
        Orther // 
    }

    public enum StatusOrder
    {
        Processing, // đang xử lý
        Confirmed, // đã xác nhận
        Completed, // đã hoàn thành
        Cancel, // đã hủy
        Orther // khác
    }
}
