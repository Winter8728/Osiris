using System;
namespace Osiris.Model
{
	/// <summary>
	/// DeviceInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DeviceInfo
	{
		public DeviceInfo()
		{}
		#region Model
		private int _id;
		private string _deviceid;
		private string _brightness;
		private string _temperature;
		private string _powerwaste;
		private string _viewmodel;
		private string _switch;
		private bool _islock= false;
        private string _lon;
        private string _lat;
		private DateTime? _createtime;
		private DateTime? _updatetime;
		private string _creator;
		private string _remark;
        private string _gyroscope;

		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DeviceId
		{
			set{ _deviceid=value;}
			get{return _deviceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Brightness
		{
			set{ _brightness=value;}
			get{return _brightness;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Temperature
		{
			set{ _temperature=value;}
			get{return _temperature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Powerwaste
		{
			set{ _powerwaste=value;}
			get{return _powerwaste;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ViewModel
		{
			set{ _viewmodel=value;}
			get{return _viewmodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Switch
		{
			set{ _switch=value;}
			get{return _switch;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsLock
		{
			set{ _islock=value;}
			get{return _islock;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string Lon
        {
            set { _lon = value; }
            get { return _lon; }
        }
        public string Lat
        {
            set { _lat = value; }
            get { return _lat; }
        }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Creator
		{
			set{ _creator=value;}
			get{return _creator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
        /// <summary>
        /// 陀螺仪
        /// </summary>
        public string Gyroscope
        {
            get { return _gyroscope; }
            set { _gyroscope = value; }
        }
		#endregion Model

	}
}

