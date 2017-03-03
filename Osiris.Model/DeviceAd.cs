using System;
namespace Osiris.Model
{
	/// <summary>
	/// DeviceAd:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DeviceAd
	{
		public DeviceAd()
		{}
		#region Model
		private int _id;
		private int? _adtype=0;
        private string _adtext;     
		private string _adpath;
        private string _thumbpath;
		private int? _repeatnum;
		private string _eare;
		private DateTime? _begintime;
		private DateTime? _endtime;
		private DateTime? _createtime;
		private DateTime? _updatetime;
		private string _creator;
		private string _remark;
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
		public int? AdType
		{
			set{ _adtype=value;}
			get{return _adtype;}
		}
        public string AdText
        {
            get { return _adtext; }
            set { _adtext = value; }
        }   
		/// <summary>
		/// 
		/// </summary>
		public string AdPath
		{
			set{ _adpath=value;}
			get{return _adpath;}
		}
        public string ThumbPath
        {
            get { return _thumbpath; }
            set { _thumbpath = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int? RepeatNum
		{
			set{ _repeatnum=value;}
			get{return _repeatnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Eare
		{
			set{ _eare=value;}
			get{return _eare;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BeginTime
		{
			set{ _begintime=value;}
			get{return _begintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
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
		#endregion Model

	}
}

