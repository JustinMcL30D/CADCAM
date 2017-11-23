﻿%% BoltTool
% BOLTTOOL Takes a struct input and calculates applicable stresses for
% semi-permanent fasteners
function BoltTool()

%%
% If the number of input arguments is less than 2, declare defaults. This
% is used for debugging and testing.
if nargin < 2
   b = struct('F',1340,...    % Shearing Force in N
              't',6.08,...    % Thickness of member
              'mxA',240,...   % Cross sectional area of weakeast connected member
              'SyM',250);     % Yield Strength of weakest member
   n = 3.0;
end

bdia = 5.9; %mm initial bolt size
nbB = 0;
ntau = 0;

while (nbB < n) || (ntau < n)
    
bdia = bdia+.1;
%% Pure Shear Failure Mode
% Find cross sectional area of bolt
xA = (pi/4)*bdia^4;

%%
% Determine shear stress
tau = b.F/b.mxA;

%% Tensile Failure of Member
% Determine tensile stress of member using cross-sectional area of attached
% member/plate with area of bolt substracted.
sigmaM = b.F/b.mxA;

%% Crushing (Bearing Failure) of Bolt or Member
% Determine bearing stress in bolt
bearing_sigmaB = -b.F/bdia;

%%
% Determine bearing stress in member
bearing_sigmaM = -b.F/(bdia*b.t);

%% Safety Factors
% Calculate safety factor for tensile failure of member
nMemTensile = b.SyM/sigmaM;

%%
% Calculate safety factor for bearing load in member
nMemBearing = b.SyM/bearing_sigmaM;

assert(abs(nMemTensile) > n,'Possible Tensile Failure of Member');
assert(abs(nMemBearing) > n,'Possible Bearing Failure of Member');
%%
% Declare Proof Loads for Grade 4.8 Bolts
Sp = 310;
nbB = Sp/abs(bearing_sigmaB);
ntau = Sp/tau;

end

fprintf('Bolt Diameter is %d mm.\n',bdia);

end % End function

