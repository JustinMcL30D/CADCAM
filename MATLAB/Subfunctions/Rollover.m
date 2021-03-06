function [track_width] = Rollover(log_id,track_width, turning_radius, Ks_f, Ks_r,md,gc)

if nargin < 7
    warning('Not enough input arguments, using default settings.');
    log_id = 0;
    md = 110; %mass of the driver
    track_width = 55*25.4;
    turning_radius = 2.3;
    Ks_f = 8143.4;
    Ks_r = 17598.7;
    gc = 0.252; %centre of gravity
end

%%
% Convert to meters
track_width = track_width/1000;
turning_radius = turning_radius/1000;
gc = gc/1000;


%% Declare initial values
% Average velocity of 35 mph
velocity = 15.64;

%%
% Mass of vehicle
mv = 195.0; % [kg]

%%
% Total mass
mass = mv + md; % [kg]

%%
% Height of centre of gravity
COG_y = 1.076 + gc - 0.252;

%%
% Roll Centre height
h_r = 1.016 + gc - 0.252; 

%%
% Front and rear separation
sep_f = 1.016;
sep_r = 1.016;

%% 
% Find front and back roll stiffness from Equation (\ref{eq:K_roll})
K_f = 0.5*Ks_f*sep_f^2;
K_r = 0.5*Ks_r*sep_r^2;

%% 
% Find roll rate from Equation (\ref{eq:R_roll})
Roll_rate = (mass*9.81*h_r)/(K_f + K_r - mass*9.81*h_r);

%%
% Ratio of lateral acceleration to gravitational acceleration from Equation (\ref{eq:ratio_roll})
Ratio = (track_width/(2*COG_y) * 1/(1+Roll_rate*(1-(h_r/COG_y))));

%% 
% finding the lateral acceleration
acc = velocity^2 / turning_radius;

%%
% Define gravitational acceleration
g = 9.81;

while acc/g < Ratio && track_width < 1.397
    warning('Vehicle could rollover. Increasing track width');
    track_width = track_width + 0.025;
    Ratio = (track_width/(2*COG_y) * 1/(1+Roll_rate*(1-(h_r/COG_y))));
end %while loop

if track_width >= 1.397 && acc/g < Ratio
    msg = ['The vehicle is at risk of tipping over in high speed corners.',...
           ' Maximum track width set by Baja SAE rules has been reached. ',...
           ' Consider lowering the ground clearance or increasing the ',...
           'natural frequency of the springs.'];
    msgbox(msg,'WARNING','warn');
end

if log_id ~= 0 
    fprintf(log_id,'Maximum lateral acceleration %.1f g\n',acc/g);
end

track_width = track_width*1000;
end %function
