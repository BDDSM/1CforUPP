
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/VidyObshhestvennoPoleznojjDeyatelnosti")]
	[Route("/Catalogs/VidyObshhestvennoPoleznojjDeyatelnosti/{Code}")]
	public class VidyObshhestvennoPoleznojjDeyatelnostiRequest/*�����������������������������������������*/: V82.�����������������.�����������������������������������,IReturn<VidyObshhestvennoPoleznojjDeyatelnostiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyObshhestvennoPoleznojjDeyatelnostiResponse//����������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyObshhestvennoPoleznojjDeyatelnostis")]
	[Route("/Catalogs/VidyObshhestvennoPoleznojjDeyatelnostis/{Codes}")]
	public class VidyObshhestvennoPoleznojjDeyatelnostisRequest/*�����������������������������������������*/: IReturn<List<VidyObshhestvennoPoleznojjDeyatelnostiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyObshhestvennoPoleznojjDeyatelnostisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyObshhestvennoPoleznojjDeyatelnostisResponse//����������������������������������������
	{
		public string Result {get;set;}
	}


	public class VidyObshhestvennoPoleznojjDeyatelnostiService /*�����������������������������������������*/ : Service
	{
		public object Any(VidyObshhestvennoPoleznojjDeyatelnostiRequest request)
		{
			return new VidyObshhestvennoPoleznojjDeyatelnostiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyObshhestvennoPoleznojjDeyatelnostiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������������������.�����������(���������);
				if (������ == null)
				{
					return new VidyObshhestvennoPoleznojjDeyatelnostiResponse() {Result = "����������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������������������.�����������(1);
			}
		}

		public object Get(VidyObshhestvennoPoleznojjDeyatelnostisRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������������������.�����������(���������);
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
