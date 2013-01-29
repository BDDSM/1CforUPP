
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyRaspredeleniyaPoProektam")]
	[Route("/Catalogs/VidyRaspredeleniyaPoProektam/{Code}")]
	public class VidyRaspredeleniyaPoProektamRequest/*���������������������������������*/: V82.�����������������.���������������������������,IReturn<VidyRaspredeleniyaPoProektamRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyRaspredeleniyaPoProektamResponse//��������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyRaspredeleniyaPoProektams")]
	[Route("/Catalogs/VidyRaspredeleniyaPoProektams/{Codes}")]
	public class VidyRaspredeleniyaPoProektamsRequest/*���������������������������������*/: IReturn<List<VidyRaspredeleniyaPoProektamRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyRaspredeleniyaPoProektamsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyRaspredeleniyaPoProektamsResponse//��������������������������������
	{
		public string Result {get;set;}
	}


	public class VidyRaspredeleniyaPoProektamService /*���������������������������������*/ : Service
	{
		public object Any(VidyRaspredeleniyaPoProektamRequest request)
		{
			return new VidyRaspredeleniyaPoProektamResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyRaspredeleniyaPoProektamRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyRaspredeleniyaPoProektamResponse() {Result = "��������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������������.�����������(1);
			}
		}

		public object Get(VidyRaspredeleniyaPoProektamsRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������������.�����������(���������);
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
