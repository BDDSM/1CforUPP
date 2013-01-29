
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyZametok")]
	[Route("/Catalogs/VidyZametok/{Code}")]
	public class VidyZametokRequest/*�����������������*/: V82.�����������������.�����������,IReturn<VidyZametokRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyZametokResponse//����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyZametoks")]
	[Route("/Catalogs/VidyZametoks/{Codes}")]
	public class VidyZametoksRequest/*�����������������*/: IReturn<List<VidyZametokRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyZametoksRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyZametoksResponse//����������������
	{
		public string Result {get;set;}
	}


	public class VidyZametokService /*�����������������*/ : Service
	{
		public object Any(VidyZametokRequest request)
		{
			return new VidyZametokResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyZametokRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������.�����������(���������);
				if (������ == null)
				{
					return new VidyZametokResponse() {Result = "����������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������.�����������(1);
			}
		}

		public object Get(VidyZametoksRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
