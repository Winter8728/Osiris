using System;
namespace Osiris.Model
{
	/// <summary>
	/// Coordinate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Coordinate
	{
		public Coordinate()
		{}
		#region Model
		private int _id;
		private string _eare; 
        private string _lon;
        private string _lat;
		private string _logoname;
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
		public string Eare
		{
			set{ _eare=value;}
			get{return _eare;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Lon
		{
			set{ _lon=value;}
			get{return _lon;}
		}
        public string Lat
        {
            set { _lat = value; }
            get { return _lat; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string LogoName
		{
			set{ _logoname=value;}
			get{return _logoname;}
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

